using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BallScore : MonoBehaviour
{
  


    void Start()
    {
        
      

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter2D(Collider2D other)
    {
       
        Vector2 transPos = transform.position;
        Vector2 closePos = other.ClosestPoint(transPos);
        Vector2 dir = (transPos - closePos).normalized;
        if (other.tag == "scorearea1" && dir.y >= 1)
        {
            Debug.Log("1");
            Scorecode.Score1 = Scorecode.Score1 + 1;
        }
        else if (other.tag == "scorearea2" && dir.y >= 1)
        {
            Scorecode.Score2 = Scorecode.Score2 + 1;
            Debug.Log("2");
                
        }
        
        if (Scorecode.Score1 >= 3)
        {
            FindObjectOfType<Game_Manager>().Endgame();
        }
        if (Scorecode.Score2 >= 3)
        {
            FindObjectOfType<Game_Manager>().Endgame2();
        }
    }
}
