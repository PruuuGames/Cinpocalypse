using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    #region Variables
    public int m_startingHealth;
		private AudioSource audioSource;
		public AudioClip[] dyingSounds;
    private int m_currentHealth;
    #endregion

    #region UnityMethods
	
	void Awake()
	{
        m_currentHealth = m_startingHealth;
	}
	
    void Start ()
	{
		audioSource = this.GetComponent<AudioSource>();
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
							AudioClip randomSound = GetRandomSound();
							audioSource.PlayOneShot(randomSound);
							this.transform.position = new Vector3(-100, 0, 0);
              StartCoroutine(WaitAndDie(randomSound));
            }
        }
    }
		
		IEnumerator WaitAndDie(AudioClip randomSound)
		{
			yield return new WaitForSeconds(randomSound.length);
			Destroy(this.gameObject);
		}

    #endregion

    #region UserMethods
		private AudioClip GetRandomSound()
		{
			return dyingSounds[(int) (Mathf.Ceil(Random.value * 3) - 1)];
		}

    #endregion

    #region Get/Set

    #endregion

    #region Routines

    #endregion
}

