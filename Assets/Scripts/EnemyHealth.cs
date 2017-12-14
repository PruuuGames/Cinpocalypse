using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    #region Variables
    public int m_startingHealth;
    private int m_currentHealth;
    #endregion

    #region UnityMethods
	
	void Awake()
	{
        m_currentHealth = m_startingHealth;
	}
	
    void Start ()
	{
	
	}
	
	void Update ()
	{
	
	}
	
	void FixedUpdate()
	{
	
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            m_currentHealth -= 50;
            if(m_currentHealth <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    #endregion

    #region UserMethods

    #endregion

    #region Get/Set

    #endregion

    #region Routines

    #endregion
}

