using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Console.WriteLine("Here!");
        
    }



}
