using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProof : MonoBehaviour
{

    [SerializeField] GameObject gb;
    [SerializeField] SpriteRenderer sr;

    private SpriteRenderer selfSR;
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        selfSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.name == "Player" )
        {
            StartCoroutine(timerD());

        }

       
    }

    IEnumerator timerD()
    {

        sr.color = new Color(1f, 1f, 1f, 0.25f);

        //collision.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 0.5f);

        gb.layer = 10;

        selfSR.color = new Color(1f, 1f, 1f, 0f);

        yield return new WaitForSeconds(5);

        sr.color = new Color(1f, 1f, 1f, 1f);

        gb.layer = 1;


        Destroy(gameObject);

    }
}
