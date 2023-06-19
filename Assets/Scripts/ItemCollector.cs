using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static Unity.VisualScripting.Metadata;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] public Text cherriesText;
    [SerializeField] public Text cherriesText2;
    [SerializeField] public AudioSource collectSound;
    public GameObject[] cherryOnScene;

    
    public int cherries = 0;
    public float totalCherry;

    
    public CherryBar cherryBar;

    private void Start()
    {

        cherryOnScene = GameObject.FindGameObjectsWithTag("Cherry");

        totalCherry = cherryOnScene.Length;


        cherryBar.setMaxcherry(totalCherry);
        cherryBar.Setcherry(0);

        cherriesText.text = cherries + "/" + totalCherry;
        cherriesText2.text = cherries + "/" + totalCherry;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {

            Destroy(collision.gameObject);
            cherries++;
            cherryBar.Setcherry(cherries);            
            cherriesText.text = cherries+"/"+ totalCherry;
            cherriesText2.text = cherries + "/" + totalCherry;
            collectSound.Play();

        }

        if(cherries == totalCherry)
        {

            cherriesText.text = "Hepsi Toplandı";
            cherriesText2.text = "Hepsi Toplandı";
        }
    }
}
