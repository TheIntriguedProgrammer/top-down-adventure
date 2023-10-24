using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsound : MonoBehaviour
{
    public AudioSource Doorsfx;
    // Start is called before the first frame update add the rest the code for the door ; https://pixabay.com/sound-effects/search/sound%20effects%20door/ for
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("i hear yah");
            Doorsfx.Play();
        
        
        }
    
    
    
    
    }
}
