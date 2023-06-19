using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDetect : MonoBehaviour
{
    // Start is called before the first
    //
    // frame update


    private Rigidbody2D rb;
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name == "Player")
        {

            rb = collision.GetComponent<Rigidbody2D>();

            rb.mass = 10;



            
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        rb = collision.GetComponent<Rigidbody2D>();

        rb.mass = 1;

    }


}
