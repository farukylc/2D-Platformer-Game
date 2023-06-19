using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    //public Animator anim;

    
    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();

        //transform.Rotate(0, 180f, 0);
        InvokeRepeating("shoot", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void shoot()
    {

        Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);


    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.name == "Player")
    //    {

    //        Destroy(gameObject);

    //        //anim.Play("Death Enemy");
    //    }
    //}



}
