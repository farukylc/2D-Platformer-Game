using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager;
using UnityEngine;

public class GrabObjects : MonoBehaviour
{
    [SerializeField] private Transform grabPoint;
    [SerializeField] private Transform rayPoint;
    [SerializeField] private float rayDistance;
    private GameObject grarbbedObject;
    private int layerIndex;

    public RaycastHit2D hitInfo;
    void Start()
    {

        layerIndex = LayerMask.NameToLayer("Holdable Box");


    }

    // Update is called once per frame
    void Update()
    {
        hitInfo = Physics2D.Raycast(rayPoint.position, transform.right, rayDistance);

        if(hitInfo.collider != null && hitInfo.collider.gameObject.layer == layerIndex)
        {
            if(Input.GetKeyDown(KeyCode.E) && grarbbedObject == null)
            {

                grarbbedObject = hitInfo.collider.gameObject;
                grarbbedObject.GetComponent<Rigidbody2D>().isKinematic = true;
                grarbbedObject.transform.position = grabPoint.position;
                grarbbedObject.transform.SetParent(transform);
                Debug.Log("cisim alındı");



            }

            else if (Input.GetKeyDown(KeyCode.E))
            {

                grarbbedObject.GetComponent<Rigidbody2D>().isKinematic = false;

                grarbbedObject.transform.SetParent(null);
                grarbbedObject = null;


            }



            

        }

       
    }
    public void Interaction()
    {
        if (hitInfo.collider != null && hitInfo.collider.gameObject.layer == layerIndex)
        {

            if (grarbbedObject == null)
            {

                grarbbedObject = hitInfo.collider.gameObject;
                grarbbedObject.GetComponent<Rigidbody2D>().isKinematic = true;
                grarbbedObject.transform.position = grabPoint.position;
                grarbbedObject.transform.SetParent(transform);
                Debug.Log("cisim alındı");

            }
            else if (grarbbedObject != null)
            {

                grarbbedObject.GetComponent<Rigidbody2D>().isKinematic = false;

                grarbbedObject.transform.SetParent(null);
                grarbbedObject = null;


            }



        }
            

    }
}
