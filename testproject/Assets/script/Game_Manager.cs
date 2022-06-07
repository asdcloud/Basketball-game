using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Manager : MonoBehaviour
{
    
    public void  Endgame()
    {
        
            
        Debug.Log("end");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

    public void Endgame2()
    {


        Debug.Log("end");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
