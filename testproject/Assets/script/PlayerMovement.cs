using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    void Update() {
        horizontalMove = Input.GetAxisRaw("P1_Horizontal") * runSpeed;
        if (Input.GetButtonDown("P1_Jump")) {
            jump = true;
        }
    }

    void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
