using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody m_Rigidbody;
    int m_Orignalx;
    int m_Orignaly;
    int m_Orignalz;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            m_Rigidbody.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            m_Rigidbody.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.W))
            m_Rigidbody.AddForce(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            m_Rigidbody.AddForce(Vector3.back);
    }
}
