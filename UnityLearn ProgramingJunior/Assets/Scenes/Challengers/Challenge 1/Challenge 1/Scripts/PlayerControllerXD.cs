using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerXD : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public GameObject plane;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // el usuario va haceria adelante por el input
        //  horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("VerticalUp");
        verticalInput = Input.GetAxis("VerticalDown");


        //se mueve hacia atras el avion
        // transform.Translate(Vector3.back * speed);

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
