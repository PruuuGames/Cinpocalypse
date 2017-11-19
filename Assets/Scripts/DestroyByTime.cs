using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

    public int m_FadeTime;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, m_FadeTime);
	}

}
