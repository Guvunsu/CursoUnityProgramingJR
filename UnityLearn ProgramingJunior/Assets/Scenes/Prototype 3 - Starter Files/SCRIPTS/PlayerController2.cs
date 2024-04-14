using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {
    public Rigidbody p1RB;
    public float jumpForce = 10.0f;
    public float gravityModifier;
    public bool isonGround = true;
    public bool gameOver = false;
    

    void Start() {
        p1RB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update() {
        jump();

    }
    public void jump() {
        if (Input.GetKeyDown(KeyCode.Space) && isonGround) {

            p1RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isonGround = false;
        }

    }
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isonGround = true;
        } else if (collision.gameObject.CompareTag("Obstacle"){
            gameOver = true;
            Debug.Log("GameOver");
        }
    }

}
