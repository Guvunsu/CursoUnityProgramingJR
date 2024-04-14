using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayerPrototype4 : MonoBehaviour {
    public Rigidbody body;
    private GameObject focalPoint;
    Vector3 awayFromPlayer;


    public float speed = 5;
    public bool hasPowerUp;
    private float powerupStrength = 15.0f;

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
    private void OnTriggerEnter(Collider power) {
        if (power.CompareTag("PowerUp")) {
            Destroy(power.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }
    IEnumerator PowerupCountdownRoutine() {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
    }
    private void OnCollisionEnter(Collision collisions) {
        if (collisions.gameObject.CompareTag("Enemy") && hasPowerUp) {
            body = collisions.gameObject.GetComponent<Rigidbody>();
            awayFromPlayer = (collisions.gameObject.transform.position - transform.position);
            Debug.Log("Collided with" + collisions.gameObject.name + "with powerup set to" + hasPowerUp);
            body.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
}
