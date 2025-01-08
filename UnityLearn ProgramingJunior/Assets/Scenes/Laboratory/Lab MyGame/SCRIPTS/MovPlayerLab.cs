using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayerLab : MonoBehaviour {

    public Rigidbody rb;

    public float speed = 0.0f;
    [SerializeField] float zBound;
    float inHi, inVe;

    void Start() {
        rb.GetComponent<Rigidbody>().velocity = Vector3.zero;//o solo llamar el rb seria suficiente
    }

    // Update is called once per frame
    void Update() {
        movPlayerLab();
        containPlayerPosition();
    }
    void containPlayerPosition() {
        if (transform.position.z < -zBound) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z < zBound) {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
    void movPlayerLab() {

        inHi = Input.GetAxis("Horizontal");
        inVe = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            speed = 30.0f;
        } else {
            speed = 15f;
        }
        Vector3 move = new Vector3(inHi, 0, inVe) * speed * Time.deltaTime;
        transform.Translate(move, Space.World); // Movimiento suave
    }
    private void OnCollisionEnter(Collision other) {
        //enemy
        if (other.gameObject.CompareTag("Enemy")) {
            Destroy(this.gameObject, 1f);
            Debug.Log(" El enemigo me a tocado D:< ");
        }
        //powerUp
        if (other.gameObject.CompareTag("PowerUp")) {
            Destroy(this.gameObject, 1f);
            Debug.Log(" El powerUp me a tocado D:< ");
        }
    }
}

