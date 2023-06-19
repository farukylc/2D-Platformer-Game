using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalWaypoint : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 1;

    [SerializeField] private float speed = 2f;


    

    private void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}