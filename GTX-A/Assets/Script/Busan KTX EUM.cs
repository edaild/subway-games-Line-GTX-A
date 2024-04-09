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
            Debug.Log("����ġ ����");

        if (collision.gameObject.tag == "Train stop")
            Debug.Log("��߿� �Դϴ�. 3���ִ� ����ϼ���");

        if (collision.gameObject.tag == "Seoul")
            Debug.Log(" �̹����� ���￪ �Դϴ�. ����ġ ����");

        if (collision.gameObject.tag == "Samseong")
            Debug.Log(" �̹����� �Ｚ�� �Դϴ�. ����ġ ����");

        if (collision.gameObject.tag == "Suseo")
            Debug.Log(" �̹����� ������ �Դϴ�. ����ġ ����");


    }
}

  
