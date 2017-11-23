using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    #region Variables
    private float speed = 2.5f;
    private Transform m_player;
    #endregion

    #region UnityMethods
	
	void Awake()
	{
        m_player = GameObject.FindGameObjectWithTag("Player").transform;
    }
	
    void Start ()
	{
	
	}

    void Update()
    {
        transform.LookAt(m_player.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        if (Vector3.Distance(transform.position, m_player.position) > 0.5f)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

    }
	void FixedUpdate()
	{
	
	}
	
    #endregion

    #region UserMethods
	
    #endregion
	
	#region Get/Set
    
    #endregion

    #region Routines
    
    #endregion
}

