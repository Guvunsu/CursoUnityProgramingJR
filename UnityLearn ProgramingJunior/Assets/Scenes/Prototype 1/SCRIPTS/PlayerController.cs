using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float HorizontalInput;
    private float ForwarInput;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Input del jugador 

        HorizontalInput = Input.GetAxis("Horizontal");
       


        // move the vehicule forward
        //transform.Translate(0, 0, 1);

        //se mueve adelante el vehiculo

        transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwarInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * HorizontalInput);

        //we turn the vehicule , 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * HorizontalInput);
    }
}
