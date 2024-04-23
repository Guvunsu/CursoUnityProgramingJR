using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayerPrototype4 : MonoBehaviour {
    public Rigidbody body;
    private GameObject focalPoint;
    public GameObject powerupIndi;
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
        powerUpIndicators();
    }
    void MovePlayerPr4() {
        inVe = Input.GetAxis("Vertical");
        body.AddForce(focalPoint.transform.forward * inVe * speed);
    }
    void powerUpIndicators() {
        powerupIndi.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }
    private void OnTriggerEnter(Collider power) {
        if (power.CompareTag("PowerUp")) {
            Destroy(power.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndi.gameObject.SetActive(true);
        }
    }
    IEnumerator PowerupCountdownRoutine() {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerupIndi.gameObject.SetActive(false);
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
