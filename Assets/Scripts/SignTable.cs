using System.Collections;
using System.Collections.Generic;
//using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class SignTable : MonoBehaviour

{

    [SerializeField] private Image message;
    public bool UIbuttonChechk = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "Player" && Input.GetKey(KeyCode.E))
        {
            message.gameObject.SetActive(true);
            
            
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            UIbuttonChechk = true;


        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Player")
        {
            message.gameObject.SetActive(false);
            UIbuttonChechk = false;
        }
    }

    public void readButton()
    {

        if(UIbuttonChechk == true)
        {

            message.gameObject.SetActive(true);
        }

        else if(UIbuttonChechk == false)
        {


            message.gameObject.SetActive(false);
        }


    }

   
}
