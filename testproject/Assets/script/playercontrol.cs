using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float speed = 0.1f;
    void Start() {
        print("Start");
    }

    // Update is called once per frame
    void Update() {
        print("Update");
        if(Input.GetKey(KeyCode.RightArrow)) {
            this.gameObject.transform.position += new Vector3(speed, 0, 0);
        }else if (Input.GetKey(KeyCode.LeftArrow)) {
            this.gameObject.transform.position += new Vector3(-speed, 0, 0);
        }else if (Input.GetKey(KeyCode.UpArrow)) {
            this.gameObject.transform.position += new Vector3(0, speed, 0);
        }else if (Input.GetKey(KeyCode.DownArrow)) {
            this.gameObject.transform.position += new Vector3(0, -speed, 0);
        }
    }
}
