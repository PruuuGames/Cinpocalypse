using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    #region Variables
    private bool m_isPaused = false;

    private float m_moveHorizontal;
    private float m_moveVertical;

    private int m_FloorMask;
    private float m_CamRayLenght = 100f;
    
    private bool m_isWalking = false;
    
    private Rigidbody2D m_rigidbody2D;

    public float m_moveSpeed = 5f;
    public float m_turnSpeed = 5f;
    #endregion

    #region UnityMethods

    private void Awake()
    {
        m_FloorMask = LayerMask.GetMask("Floor");

        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        if (!m_isPaused)
        {
            m_moveHorizontal = Input.GetAxis("Horizontal");
            m_moveVertical = Input.GetAxis("Vertical");

            Move(m_moveHorizontal, m_moveVertical);
            Turn();
            //Animation(m_moveHorizontal, m_moveVertical);
        }        
    }

    #endregion

    #region UserMethods

    void Move(float horizontal, float vertical)
    {
        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        movement = movement * m_moveSpeed * Time.deltaTime;
        m_rigidbody2D.MovePosition(transform.position + movement);
    }

    void Turn()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;
        if (Physics.Raycast(ray, out floorHit, m_CamRayLenght, m_FloorMask))
        {
            Vector3 worldMouse = floorHit.point;
            worldMouse.z = transform.position.z;
            Vector3 lookDirection = worldMouse - transform.position;
            transform.right = Vector3.MoveTowards(transform.right, lookDirection, m_turnSpeed);
        }
    }

    //void Animation(float horizontal, float vertical)
    //{
    //    m_isWalking = horizontal != 0f || vertical != 0f;
    //    m_animator.SetBool("IsWalking", m_isWalking);
    //}
    #endregion

    #region Get/Set

    #endregion

    #region Routines

    #endregion

}

