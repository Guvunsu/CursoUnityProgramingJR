using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatedCamara : MonoBehaviour {
    public float rotationSpeed;
    float inHi;

    void Start() {

    }

    // Update is called once per frame
    void Update() {
        rotationCamaras();
    }
    void rotationCamaras() {
        inHi = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, inHi * rotationSpeed * Time.deltaTime);
    }
}
