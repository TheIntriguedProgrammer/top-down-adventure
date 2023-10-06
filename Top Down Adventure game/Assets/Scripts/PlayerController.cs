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
    public GameObject key;
    

    // Start is called before the first frame update
    void Start()
    {


        
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
            key.SetActive(false);// key disappears
            gotKey = true;// player has the key now

        
        
        
        
        
        
        }
    }



}
