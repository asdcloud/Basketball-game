using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class menu : MonoBehaviour{
    
    [SerializeField] GameObject PauseMenu;
    [SerializeField] TextMeshProUGUI ScoreSettingText;
    [SerializeField] TextMeshProUGUI TimeSettingText;
    void Update()
    {   if(SceneManager.GetActiveScene().buildIndex  == 0)
        {
            ScoreSettingText.text = BallScore.ScoreToWin.ToString();
            TimeSettingText.text = Timer.m_min.ToString();
        }
    }
    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }
    public void returnmenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        setting.i = 0;
    }
    public void Quitgame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
   
    public void Pause()
    {
        if(setting.i == 0){
            Debug.Log("Pause!");
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
            setting.i = 1;
        }
        else if (setting.i == 1)
        {
            Time.timeScale = 1f;
            PauseMenu.SetActive(false);
            setting.i = 0;
        }

    }
    public void Resume()
    {
        if (setting.i == 1)
        {
            Time.timeScale = 1f;
            PauseMenu.SetActive(false);
            setting.i = 0;
        }
        
    }
    public void PlusScoreToWin()
    {
        if(BallScore.ScoreToWin <= 10)
        {
            BallScore.ScoreToWin = BallScore.ScoreToWin + 1;
            Debug.Log(BallScore.ScoreToWin);
        }
    }
    public void MinusScoreToWin()
    {
        if(BallScore.ScoreToWin > 1)
        {
            BallScore.ScoreToWin = BallScore.ScoreToWin - 1;

        }
    }
    public void PlusTime()
    {
        if(Timer.m_min < 10)
        {
           Timer.m_min = Timer.m_min + 1; 
        }
    }
    public void MinusTime()
    {
        if(Timer.m_min > 1)
        {
           Timer.m_min = Timer.m_min - 1; 
        }
    }
}
