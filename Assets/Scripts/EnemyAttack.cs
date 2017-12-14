using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {
    #region Variables
    public float m_attackTimer = 1f;
    public int m_attackDamage = 5;

    private Animator m_animator;
    private GameObject m_player;
    private PlayerHealth m_playerHealth;
    private bool m_playerInRange;
    private float m_timer;
    #endregion

    #region UnityMethods
	
	void Awake()
	{
        m_player = GameObject.FindGameObjectWithTag("Player");
        m_playerHealth = m_player.GetComponent<PlayerHealth>();
        m_playerInRange = false;
        //TODO ENEMY HEALTH SCRIPT
        m_animator = GetComponent<Animator>();
	}
	
    void Start ()
	{
	
	}
	
	void Update ()
	{
        m_timer += Time.deltaTime;

        if(m_timer >= m_attackTimer && m_playerInRange)
        {
            Attack();
        }

        // TODO STOP CAUSE PLAYER DEAD BITCH
	}
	
	void FixedUpdate()
	{
	
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == m_player)
        {
            m_playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject == m_player)
        {
            m_playerInRange = false;
        }
    }

    #endregion

    #region UserMethods
    void Attack()
    {
        m_timer = 0f;
        if (m_playerHealth.m_CurrentHealth > 0)
        {
            m_playerHealth.TakeDamage(m_attackDamage);
        }
    }
    #endregion

    #region Get/Set

    #endregion

    #region Routines

    #endregion
}

