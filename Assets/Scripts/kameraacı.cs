using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraacı : MonoBehaviour


{

    [SerializeField] private Camera mainCamera;
    [SerializeField] private float newAngle = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        mainCamera.orthographicSize = newAngle;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        mainCamera.orthographicSize = 5;
    }
}
