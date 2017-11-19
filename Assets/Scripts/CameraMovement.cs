using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Transform m_Target;
    public float m_Smoothing = 5f;

    private Vector3 m_Offset;

    // Use this for initialization
    void Start ()
    {
        m_Offset = transform.position - m_Target.position;
    }

    void FixedUpdate()
    {
        Vector3 targetCamPos = m_Target.position + m_Offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, m_Smoothing * Time.deltaTime);
    }
}
