using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTeleport : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject enemy;
    [SerializeField] Transform targetLoc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {

            enemy.gameObject.transform.position = targetLoc.position;


        }
    }
}
