using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dialog : MonoBehaviour
{

    private bool hit = false;
    public GameObject Dialogwindow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        // if (Dialogwindow != null)
        //{

        //    if (hit != true)
        //    {
        //        Dialogwindow.SetActive(false);



        //     }
        //    else
        //    {
        //        Dialogwindow.SetActive(true);

        //    }
        //  }
        //  if (Input.GetKey("e"))
        //  {
        //     hit = false;
        //     Destroy(Dialogwindow);

        // }


       if (Dialogwindow != null)
        {

            if (hit != true)
            {
                Dialogwindow.SetActive(false);



            }
            else
            {
                Dialogwindow.SetActive(true);

            }
        }
        if (Input.GetKey("e"))
        {
            hit = false;
            Destroy(Dialogwindow);

        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("yeah whats up npc");
            hit = true;

        }




    }


}
