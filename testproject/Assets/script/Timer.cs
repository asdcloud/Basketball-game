using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int m_seconds;                 
    public static int m_min = 1;              
    public int m_sec;              
    public TextMeshProUGUI m_timer;
    private int m_min_ingame;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Countdown()
    {
        m_min_ingame = m_min;
        m_timer.text = string.Format("{0}:{1}", m_min_ingame.ToString("00"), m_sec.ToString("00"));
        m_seconds = (m_min_ingame * 60) + m_sec;       

        while (m_seconds > 0)                   
        {
            yield return new WaitForSeconds(1); 

            m_seconds--;                        
            m_sec--;                           

            if (m_sec < 0 && m_min_ingame > 0)       
            {
                m_min_ingame -= 1;                    
                m_sec = 59;                     
            }
            else if (m_sec < 0 && m_min_ingame == 0)   
            {
                m_sec = 0;                      
            }
            m_timer.text = string.Format("{0}:{1}", m_min_ingame.ToString("00"), m_sec.ToString("00"));
        }

        if(Scorecode.Score1 > Scorecode.Score2)
        {
            FindObjectOfType<Game_Manager>().Endgame();
        }
        else if(Scorecode.Score2 > Scorecode.Score1)
        {
            FindObjectOfType<Game_Manager>().Endgame2();
        }
        else if(Scorecode.Score2 == Scorecode.Score1)
        {
            FindObjectOfType<Game_Manager>().Draw();
        }
        yield return new WaitForSeconds(1);   
        Time.timeScale = 0;                   
    }
}
