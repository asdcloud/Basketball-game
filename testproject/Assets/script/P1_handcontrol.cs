using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class P1_handcontrol : MonoBehaviour
{
    [SerializeField] public float handSpeed = 0.2f;
    private float handInput;
    public CollisionDetectionMode collisionDetectionMode;
    private int Trigger = 0;
    public Rigidbody2D rigidBody2D;
    public void AddTorqueImpulse(float angularChangeInDegrees)
    {
        var body = GetComponent<Rigidbody2D>();
        var impulse = (angularChangeInDegrees * Mathf.Deg2Rad) * body.inertia;

        body.AddTorque(impulse, ForceMode2D.Impulse);
    }

    void start() {
        rigidBody2D = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        handInput = Input.GetAxisRaw("P1_Hand"); 
        if(handInput == 1 && Trigger == 0)
        {
            AddTorqueImpulse(handSpeed);
            Trigger = 1;
        }else if (handInput == -1 && Trigger == 0) {
            AddTorqueImpulse(handSpeed * handInput);
            Trigger = 1;
        }else if (handInput == 0) {
            Trigger = 0;
        }
    }
}
