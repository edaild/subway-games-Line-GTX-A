using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BusanKTXEUM : MonoBehaviour
{
    public Rigidbody KTX;
    public float speed = 8f;


    void Start()
    {
        KTX = GetComponent<Rigidbody>();
    }

    void Update() {
  
        if(Input.GetKey(KeyCode.UpArrow))
        {
            KTX.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            KTX.AddForce(0, 0, +speed);
        }
    }
}

  
