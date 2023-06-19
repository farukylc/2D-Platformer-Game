using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform player; //playera erişim editörden sürükle bırak
    
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z); //z aynen tut kamera bozulmasın
        //lerp
    }
}
