using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    #region Variables

    //private Animator m_animator;
    private bool m_playerDead;

    [Header("-Health-")]
    [Space]
    public float m_StartingHealth = 100f;
    public float m_CurrentHealth;
    public Slider m_Slider;
    public Image m_FillImage;
    public Color m_FullHealthColor = Color.green;
    public Color m_ZeroHealthColor = Color.red;
    

    #endregion

    #region UnityMethods
	
	void Awake ()
    {
        m_CurrentHealth = m_StartingHealth;
        m_playerDead = false;
        SetHealthUI();
    }	

	void Update () {
        
	}

    #endregion

    #region UserMethods
	
	public void TakeDamage (int amount){
        m_CurrentHealth -= amount;
        Debug.Log(m_CurrentHealth);
        SetHealthUI();

        if (m_CurrentHealth <= 0 && !m_playerDead)
        {
            Debug.Log("Morreu");
            Death();
        }
    }
	
	public void Death(){
        m_playerDead = true;
        SceneManager.LoadScene(1);
	}

    private void SetHealthUI()
    {
        m_Slider.value = m_CurrentHealth;
        m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
    }

    #endregion

    #region Get/Set

    #endregion

    #region Routines

    #endregion
}

