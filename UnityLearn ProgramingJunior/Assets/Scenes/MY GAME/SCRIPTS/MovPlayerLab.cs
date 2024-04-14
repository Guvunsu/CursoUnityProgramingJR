using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayerLab : MonoBehaviour {
    public Rigidbody rb;
    public float speed = 0.0f;
    private float zBound = 6;
    float inHi;
    float inVe;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        movPlayerLab();
        containPlayerPosition();
    }
    void containPlayerPosition() {
        if (transform.position.z < -zBound) {
            transform.position = new Vector3(transform.position.z, transform.position.y, -zBound);
        }
        if (transform.position.z < zBound) {
            transform.position = new Vector3(transform.position.z, transform.position.y, zBound);
        }
    }
    void movPlayerLab() {

        inHi = Input.GetAxis("Horizontal");
        inVe = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            speed = 30.0f;
        }
        rb.AddForce(Vector3.forward * speed * inVe);
        rb.AddForce(Vector3.right * speed * inHi);
    }
}

