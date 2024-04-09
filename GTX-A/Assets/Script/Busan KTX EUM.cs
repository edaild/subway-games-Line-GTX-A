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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stop")
            Debug.Log("정위치 정차");

        if (collision.gameObject.tag == "Train stop")
            Debug.Log("출발역 입니다. 3분있다 출발하세요");

        if (collision.gameObject.tag == "Seoul")
            Debug.Log(" 이번역은 서울역 입니다. 정위치 정차");

        if (collision.gameObject.tag == "Samseong")
            Debug.Log(" 이번역은 삼성역 입니다. 정위치 정차");

        if (collision.gameObject.tag == "Suseo")
            Debug.Log(" 이번역은 수서역 입니다. 정위치 정차");


    }
}

  
