using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BallScore : MonoBehaviour
{
    public Transform player1Pos;
    public Transform player2Pos;
    public Transform basketballPos;
    public Rigidbody2D basketballRigidbody;
    public Rigidbody2D player1Rigidbody;
    public Rigidbody2D player2Rigidbody;

    void OnTriggerEnter2D(Collider2D other)
    {
       
        Vector2 transPos = transform.position;
        Vector2 closePos = other.ClosestPoint(transPos);
        Vector2 dir = (transPos - closePos).normalized;
        if (other.tag == "scorearea1" && dir.y >= 1)
        {
            Debug.Log("1");
            Scorecode.Score1 = Scorecode.Score1 + 1;
            basketballPos.position = new Vector2(-6, 36);
            player1Pos.position = new Vector2(3, 27);
            basketballRigidbody.velocity = new Vector2(0, 5);
            player1Rigidbody.velocity = new Vector2(0, 5);
        }
        else if (other.tag == "scorearea2" && dir.y >= 1)
        {
            Scorecode.Score2 = Scorecode.Score2 + 1;
            Debug.Log("2");
            basketballPos.position = new Vector2(3, 36);   
            player2Pos.position = new Vector2(-6, 27);
            basketballRigidbody.velocity = new Vector2(0, 5);
            player2Rigidbody.velocity = new Vector2(0, 5);
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
