using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 45.0f;

    private float horizontalInput;
    private float forwarInput;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Input del jugador 

        horizontalInput = Input.GetAxis("Horizontal");
        forwarInput = Input.GetAxis("Vertical");



        // move the vehicule forward
        //transform.Translate(0, 0, 1);

        //se mueve adelante el vehiculo

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwarInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * HorizontalInput);

        //we turn the vehicule , 
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
    
    }

