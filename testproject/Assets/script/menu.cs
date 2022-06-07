using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour{
    
    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }
    public void Quitgame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
