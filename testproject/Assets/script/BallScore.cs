using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour
{
    
    // Start is called before the first frame update
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
        Vector2 dir = (transPos-closePos).normalized;
        if(other.tag=="scorearea1"&& dir.y>=1)
        {
            Debug.Log("1");
            Scorecode.Score1 = Scorecode.Score1 + 1;
        }
        else if(other.tag=="scorearea2"&& dir.y>=1)
        {
            Debug.Log("2");
            
        }
    }
}
