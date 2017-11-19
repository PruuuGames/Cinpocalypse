using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public float m_Speed;

    private Rigidbody2D m_Rigidbody2D;

    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        m_Rigidbody2D.velocity = transform.up * m_Speed;
    }

}
