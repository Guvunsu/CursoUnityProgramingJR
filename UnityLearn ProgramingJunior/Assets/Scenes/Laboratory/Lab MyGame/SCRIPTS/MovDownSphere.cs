using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovDownSphere : MonoBehaviour {

    private Rigidbody movDownSphere;

    private float speeds = 5.0f;
    private float zDestroys = -10.0f;

    void Start() {
        instanceGetComponent();
    }
    void Update() {
        movSphereDown();
    }
    private void movSphereDown() {
        movDownSphere.AddForce(-Vector3.forward * -speeds);

        //if (transform.position.z < -zDestroys) {
        //    //Destroy(gameObject);
        //}
    }
    private void instanceGetComponent() {
        movDownSphere = GetComponent<Rigidbody>();
    }
}
