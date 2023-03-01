using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;


public class holeCollision : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {

        
        if(other.gameObject.name == "Player")
        {

            other.transform.position = new Vector3(0, 0.5f, 0);

            Debug.Log(other.attachedRigidbody);

            Rigidbody rb =  other.attachedRigidbody;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

        }



    }



}
