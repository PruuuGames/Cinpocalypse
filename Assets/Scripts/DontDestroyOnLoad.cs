using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {
    #region Variables

    #endregion

    #region UnityMethods
	
	void Awake()
	{
        GameObject.DontDestroyOnLoad(this.gameObject);
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
	
    #endregion

    #region UserMethods
	
    #endregion
	
	#region Get/Set
    
    #endregion

    #region Routines
    
    #endregion
}

