using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BallScore : MonoBehaviour
{
    [SerializeField] Transform player1Pos;
    [SerializeField] Transform player2Pos;
    [SerializeField] Transform basketballPos;
    [SerializeField] Rigidbody2D basketballRigidbody;
    [SerializeField] Rigidbody2D player1Rigidbody;
    [SerializeField] Rigidbody2D player2Rigidbody;
    [SerializeField] GameObject P1ScoreText;
    [SerializeField] GameObject P2ScoreText;

    void OnTriggerEnter2D(Collider2D other)
    {
       
        Vector2 transPos = transform.position;
        Vector2 closePos = other.ClosestPoint(transPos);
        Vector2 dir = (transPos - closePos).normalized;
        if (other.tag == "scorearea1" && dir.y >= 1)
        {
           P1ScoreText.SetActive(true);
           StartCoroutine(P1Score());
        }
        else if (other.tag == "scorearea2" && dir.y >= 1)
        {
            P2ScoreText.SetActive(true);
            StartCoroutine(P2Score());
        }     
    }

    IEnumerator P1Score()
    {
        yield return new WaitForSeconds(1);
        Scorecode.Score1 = Scorecode.Score1 + 1;
        basketballPos.position = new Vector2(-6, 36);
        player1Pos.position = new Vector2(3, 27);
        player2Pos.position = new Vector2(-6, 27);
        basketballRigidbody.velocity = new Vector2(0, 5);
        player1Rigidbody.velocity = new Vector2(0, 5);  
        player2Rigidbody.velocity = new Vector2(0, 5);   
        P1ScoreText.SetActive(false);
        if (Scorecode.Score1 >= 3)
        {
            FindObjectOfType<Game_Manager>().Endgame();
        }
    }

     IEnumerator P2Score()
    {
        yield return new WaitForSeconds(1);
        Scorecode.Score2 = Scorecode.Score2 + 1;
        basketballPos.position = new Vector2(3, 36);  
        player1Pos.position = new Vector2(3, 27);
        player2Pos.position = new Vector2(-6, 27);
        basketballRigidbody.velocity = new Vector2(0, 5);
        player1Rigidbody.velocity = new Vector2(0, 5);  
        player2Rigidbody.velocity = new Vector2(0, 5);   
        P2ScoreText.SetActive(false);
        if (Scorecode.Score2 >= 3)
        {
            FindObjectOfType<Game_Manager>().Endgame2();
        }
    }
}
