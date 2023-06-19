using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using static Unity.VisualScripting.Metadata;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    
    private GameObject[] cherryOnScene;
    private int onScreenn;

    // Start is called before the first frame update
    void Start()
    {
        finishSound = GetComponent<AudioSource>();

        
    }


    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if(onScreenn == 0)
            {
                finishSound.Play();
            }
            
            
            
            Invoke("CompleteLevel", 2f);
        }
    }

    
    private void CompleteLevel()
    {
        if(onScreenn == 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
            
        }
        else
        {
            
            
            
            
        }

    }

    private void Update()
    {
        cherryOnScene = GameObject.FindGameObjectsWithTag("Cherry");

        onScreenn = cherryOnScene.Length;

        
        
    }


}
