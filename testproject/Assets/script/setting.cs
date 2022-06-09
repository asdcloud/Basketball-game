using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;
    public static int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && i ==0)
        {   
            
            
            Debug.Log("Pause!");
            Time.timeScale = 0f;
            PauseMenu.SetActive(true);
            i = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && i==1)
        {
            Debug.Log("resume!");
            Time.timeScale = 1f;
            PauseMenu.SetActive(false);
            i = 0;
        }
        
        
            
    }
}
