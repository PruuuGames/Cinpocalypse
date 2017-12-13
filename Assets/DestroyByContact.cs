using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    #region Variables

    #endregion

    #region UnityMethods
	
	void Awake()
	{
	
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
            Destroy(this.gameObject);
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

