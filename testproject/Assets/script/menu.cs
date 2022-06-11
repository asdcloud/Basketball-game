using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour{
    
    [SerializeField] GameObject PauseMenu;
    
   
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
}
