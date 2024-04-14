using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayerPrototype4 : MonoBehaviour {
    public Rigidbody body;
    private GameObject focalPoint;
    public float speed = 5;
    float inVe;
    void Start() {
        body = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update() {
        MovePlayerPr4();
    }
    void MovePlayerPr4() {
        inVe = Input.GetAxis("Vertical");
        body.AddForce(focalPoint.transform.forward * inVe * speed);
    }
}
