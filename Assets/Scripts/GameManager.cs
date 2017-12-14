using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    #region Variables
    public Image m_background;
    public Text m_survive;
    public GameObject[] enemies;
    public Transform[] spawnPoints;
    public Transform m_player;

    private Animator m_textAnim;
    private Animator m_imgAnim;
    private bool m_gameover = false;
    private int waveSize = 10;
    private int targetSpawn;
    #endregion

    #region UnityMethods
    // Use this for initialization
    void Start () {
        m_textAnim = m_survive.GetComponent<Animator>();
        m_imgAnim = m_background.GetComponent<Animator>();
  
        StartCoroutine("StartGame");
	}
	
	// Update is called once per frame
	void Update () {
	}
    #endregion

    IEnumerator StartGame()
    {
        m_textAnim.SetBool("Fade", true);
        m_imgAnim.SetBool("Fade", true);
        yield return new WaitForSeconds(5);
        m_background.gameObject.SetActive(false);
        m_survive.gameObject.SetActive(false);
        StartCoroutine("SpawnWaves");
        StopCoroutine("StartGame");
    }

    IEnumerator SpawnWaves()
    {
        while (!m_gameover)
        {
            for (int i = 0; i < waveSize; i++)
            {
                float distance = 0;
                for (int j  = 0; j  < spawnPoints.Length ; j ++)
                {
                    float  auxDistance = Mathf.Sqrt(Mathf.Pow(m_player.position.x - spawnPoints[j].position.x, 2) + Mathf.Pow(m_player.position.y - spawnPoints[j].position.y, 2));
                    if(j == 0)
                    {
                        targetSpawn = j;
                        distance = auxDistance;
                    } else
                    {
                        if(auxDistance < distance)
                        {
                            distance = auxDistance;
                            targetSpawn = j;
                        }
                    }                    
                }
                int x = Random.Range(0, enemies.Length);
                Instantiate(enemies[x], spawnPoints[targetSpawn].position, spawnPoints[targetSpawn].rotation);
                yield return new WaitForSeconds(2);
            }
        yield return new WaitForSeconds(15);
        }        
    }

    #region UserMethods
    #endregion
}

