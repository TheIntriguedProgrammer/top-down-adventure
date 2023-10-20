using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsopen : MonoBehaviour
{

    public // add the rest the code for the door ; https://pixabay.com/sound-effects/search/sound%20effects%20door/ for the sound
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("player") 
        { Debug.Log("check check"); 
        
        
        
        
        
        }
    }
}
