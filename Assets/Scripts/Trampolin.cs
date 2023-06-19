using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private float jumpForceTramp = 11.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {

            collision.gameObject.GetComponent<Rigidbody2D>().velocity = (Vector2.up * jumpForceTramp);
            anim.Play("TrampolineAnimation");
            


        }

    }
}