using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hand : MonoBehaviour
{
    [SerializeField] private float handSpeed = 0.2f;
    [SerializeField] private Transform handPos;
    private float handInput;


    void Update()
    {
       handInput = Input.GetAxisRaw("Hand");
       Debug.Log(handPos.eulerAngles);   
    } 

    void FixedUpdate()
    {
        //按鈕是否被按下s
        if(handInput == 1)
        {
            if(handPos.eulerAngles.z < 100 || handPos.eulerAngles.z > 300)
            {
                handPos.Rotate(0,0,0.2f * handSpeed);
            }
        }
        else if(handPos.eulerAngles.z > 0 & handPos.eulerAngles.z <= 110)
        {
            handPos.Rotate(0,0,-0.2f * handSpeed); 
        }
    }
}
