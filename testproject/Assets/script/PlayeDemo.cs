using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeDemo : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        var movement = Input.GetAxisRaw("P2_Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("P2_Jump")) {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            print("jump");
        }
    }
}
