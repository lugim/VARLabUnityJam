using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    private void OnCollisionExit(Collision collision)
    {
        if (this.gameObject.tag == "Portal1")
        {

            var portalOut = GameObject.FindGameObjectWithTag("Portal2");
            collision.transform.position = portalOut.transform.position;

        }


        if (this.gameObject.tag == "Portal2")
        {
            var portalOut = GameObject.FindGameObjectWithTag("Portal1");

            collision.transform.position = portalOut.transform.position;
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {


        if (this.gameObject.tag == "Portal1In")
        {

            var portalOut = GameObject.FindGameObjectWithTag("Portal1Out");
            other.transform.position = portalOut.transform.position;

        }


    }

}
