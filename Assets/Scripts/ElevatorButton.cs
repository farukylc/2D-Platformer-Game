using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ElevatorButton : MonoBehaviour
{

    private SpriteRenderer sr;

    [SerializeField] private GameObject Platform;

    //private GameObject elevatorPlatform, elevatorAnimator;

    private bool isProgress = false;


    public bool onAreaUI = false; // UI button


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(onAreaUI);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        onAreaUI = true;
        if (collision.gameObject.name == "Player" && Input.GetKey(KeyCode.E) && isProgress == false)
        {

            sr.flipX = true;

            isProgress = true;

            

            Platform.GetComponent<WaypointFollower>().enabled = true;
            Platform.GetComponent<Animator>().enabled = true;



        }




        else if (Input.GetKey(KeyCode.R) && isProgress == true)
        {

            sr.flipX = false;

            isProgress = false;

            
            
            Platform.GetComponent<WaypointFollower>().enabled = false;
            Platform.GetComponent<Animator>().enabled = false;


        }





    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {

            onAreaUI = false;
        }
    }


    public void elevatorUIButton()
    {

        if (isProgress == false && onAreaUI == true)
         {

                sr.flipX = true;

                isProgress = true;



                Platform.GetComponent<WaypointFollower>().enabled = true;
                Platform.GetComponent<Animator>().enabled = true;



         }


        else if (isProgress == true && onAreaUI == true)
        {

            sr.flipX = false;

            isProgress = false;

            

            Platform.GetComponent<WaypointFollower>().enabled = false;
            Platform.GetComponent<Animator>().enabled = false;


        }



    }


}
