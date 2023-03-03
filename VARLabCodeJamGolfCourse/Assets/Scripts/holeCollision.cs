using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using EasyUI.Toast;

public class holeCollision : MonoBehaviour
{

    int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {


        if(other.gameObject.name == "Player")
        {

            Vector3 resetPlayer = new Vector3(-11.78f, 0.77f, 14.27f);

            other.transform.position = resetPlayer;
            score++;
            Debug.Log(other.attachedRigidbody);

            Rigidbody rb =  other.attachedRigidbody;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            //Toast message
            Toast.Show("Hole in one! Total score: "+score+"!", 1);
            //ShowAndroidToastMessage("Hole in one! Good Game!");
        }
    }
    
}
