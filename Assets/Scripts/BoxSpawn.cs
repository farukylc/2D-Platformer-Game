using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject box;
    public int x = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        while(0 < x)
        {

            Instantiate(box, spawnPoint.position, transform.rotation);

            x--;
        }

        
    }
}
