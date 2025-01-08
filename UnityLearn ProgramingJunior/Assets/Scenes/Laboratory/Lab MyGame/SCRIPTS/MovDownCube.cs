using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovDownCube : MonoBehaviour {

    private Rigidbody movDownCube;

    private float speed = 5.0f;
    private float zDestroy = -10.0f;

    void Start() {
        instanceGetComponents();
    }
    void Update() {
        movCubeDown();
        movCubeDownRotation();
    }
    private void movCubeDown() {
        movDownCube.AddForce(-Vector3.forward * -speed);

        //if (transform.position.z < -zDestroy) {
        //    Destroy(gameObject);
        //}
    }
    private void movCubeDownRotation() {//its not neccesary but i want it, its funny :P
        Vector3 rotationPos = new Vector3(movDownCube.transform.rotation.x, transform.position.y, transform.position.z);
        transform.Rotate(rotationPos);
    }
    private void instanceGetComponents() {
        movDownCube = GetComponent<Rigidbody>();
    }
}
