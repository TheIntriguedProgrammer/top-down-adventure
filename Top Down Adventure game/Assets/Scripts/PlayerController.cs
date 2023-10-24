using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// get access to the scene management library
using UnityEngine.SceneManagement; // importing SceneManagement Library


public class PlayerController : MonoBehaviour
{
    //speed variable
    public float speed = 0.5f;
    public bool gotKey = false; // remember to camel cases
    //public GameObject key;
    
    public static PlayerController instance;//  this is a variable that creates a object of the current class which will allow us to look for duplicates in the current game scene
    // creating a object of the class to be findable."static" allows us to access from anywhere.

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)// check if instance is in the scene
        {
            Destroy(gameObject);// deletes the current character in the scene
            return;// end code
        }
        
        instance = this; // when the instance is destroyed it need to be replaced with the currently used object.
        // prevent the gameobject of the character from being destroyed when enter new scene "gameObject parameter refers to the current game object in play"
        GameObject.DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position; 

        if (Input.GetKey("w"))
        {
            // player moves up 
            newPosition.y += speed; 

        }

        if (Input.GetKey("s"))
        {
            // player moves down 
            newPosition.y -= speed;
        }

        if (Input.GetKey("a"))
        {
            // player moves left
            newPosition.x -= speed;
        }
        if (Input.GetKey("d"))
        {
            //player moves right
            newPosition.x += speed;
        }



        transform.position = newPosition;






        
    }

    // code which detects the collision 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // this if statement check for a collision in the scene and then checks the tag of the gameobject the palyer is colliding with the see if it equals to the assign tag.
        if (collision.gameObject.tag.Equals("door"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(1);// access SceneManager class for LoadScene Function
            // this code allow you to load another scene
            // the name of the new scene is indoor
            // remember to add the scene to your build settings
        }
        if (collision.gameObject.tag.Equals("key")) 
        {
           
            // note the has the key after it disappears

            Debug.Log("hit aahh got key");
           // key.SetActive(false);// key disappears
           gotKey = true;// player has the key now

        }

        if (collision.gameObject.tag.Equals("scenetwodoor"))
        {

            Debug.Log("ahh hit hit");
            SceneManager.LoadScene(0); // access SceneManager 
            // this allows the player to return to the original scene when they collide with the door in scene 2.
        }

        if (collision.gameObject.tag.Equals("end exit door") && gotKey == true) // need to satisfy both conditions to be true for the player to enter the door
        {

            Debug.Log("the exit door is ");// when we interact with the end game exit door for the game.
            SceneManager.LoadScene(2);// load the end scene
        
        
        
        
        }
        if (collision.gameObject.tag.Equals("npc"))
        {
            Debug.Log("yeah whats up");
        }
    }



}
