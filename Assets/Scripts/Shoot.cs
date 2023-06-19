using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform shootingPoint;
    
    public GameObject bulletPrefab;

    public float pm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {

            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);

            

        }

        

    }


    public void shootUI()
    {

        Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);

    }
}
