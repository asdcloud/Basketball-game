using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class handcontrol : MonoBehaviour
{
    [SerializeField] public float handSpeed = 0.2f;
    private float handInput;


    void FixedUpdate()
    {
        handInput = Input.GetAxisRaw("Hand"); 
        //按鈕是否被按下s
        if(handInput == 1)
        {
            transform.Rotate(new Vector3(0, 0, handSpeed));
        }else if (handInput == -1) {
            transform.Rotate(new Vector3(0, 0, handSpeed * handInput));
        }
    }
}
