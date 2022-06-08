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
    public void Quitgame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    public void Pause()
    {
        Debug.Log("Pause!");
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }
}
