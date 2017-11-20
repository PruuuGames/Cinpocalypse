using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    #region Variables

    private Animator m_animator;
    private bool m_playerDead;
    private bool m_playerDamaged;

    public int m_startingHealth;
    public int m_currentHealth;

    public Slider m_healthSlider;

    public Image m_damageImage;
    public float m_flashSpeed = 5f;
    public Color m_flashColor = new Color(1f, 0f, 0f, 0.1f);

    #endregion

    #region UnityMethods
	
	void Awake ()
    {
        //m_animator = GetComponent <Animator> ();
        m_currentHealth = m_startingHealth;
    }	

	void Update () {
        if (m_playerDamaged)
        {
            m_damageImage.color = m_flashColor;
        } else
        {
            m_damageImage.color = Color.Lerp(m_damageImage.color, Color.clear, m_flashSpeed * Time.deltaTime);
        }
        m_playerDamaged = false;
	}

    #endregion

    #region UserMethods
	
	public void TakeDamage (int amount){
		m_playerDamaged = true;
		
		m_currentHealth -= amount;
				
		m_healthSlider.value = m_currentHealth;
		
		//Player Damaged Sound
		
		if(m_currentHealth <= 0 && !m_playerDead){
			Death();
		}
		
	}
	
	public void Death(){
		m_playerDead = true;
		
		//m_animator.SetTrigger ("Die");		
		//Player Dead Sound
	}
	
    #endregion

    #region Get/Set

    #endregion

    #region Routines

    #endregion
}

