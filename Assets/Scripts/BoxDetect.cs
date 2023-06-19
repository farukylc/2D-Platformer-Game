using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDetect : MonoBehaviour
{


    [SerializeField] private GameObject door;

    [SerializeField] private GameObject offWaypoint;

    private float speed = 2;

    void Start()
    {

        //door = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag("HoldableBox"))
        {

            door.GetComponent<VerticalWaypoint>().enabled = true;
            door.GetComponent<VerticalWaypointOff>().enabled = false;

        }




    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("HoldableBox"))
        {

            door.GetComponent<VerticalWaypoint>().enabled = false;

            door.GetComponent<VerticalWaypointOff>().enabled = true;
        }

       
    }

    
}
