using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    #region Variables
    private bool m_isPaused = false;

    private int m_equippedGun; // 1- Pistol 2- MachineGun 3- Shotgun
    private float m_nextFire;

    public float m_fireRate = 1f;
    public GameObject m_Projectile;
    public Transform m_GunBarrel;

    public int m_playerDamage;

    #endregion

    #region UnityMethods
 
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1") && Time.time > m_nextFire && !m_isPaused)
        {
            Shoot();
        }
    }

    #endregion

    #region UserMethods

    void Shoot()
    {
        m_nextFire = Time.time + m_fireRate;
        Instantiate(m_Projectile, m_GunBarrel.position, m_GunBarrel.rotation);
        Debug.Log("OI");
    }

    #endregion

    #region Get/Set
    
    #endregion

    #region Routines
    
    #endregion
}

