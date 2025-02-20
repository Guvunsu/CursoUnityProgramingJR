using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX4 : MonoBehaviour {
    private Rigidbody playerRb;
    private float speed = 500;
    private GameObject focalPoint;
    public ParticleSystem dust;

    public bool hasPowerup;
    public GameObject powerupIndicator;
    public int powerUpDuration = 5;

    private float normalStrength = 10; // how hard to hit enemy without powerup
    private float powerupStrength = 25; // how hard to hit enemy with powerup

    void Start() {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
        StartCoroutine(PowerupCooldown());
    }

    void Update() {
        MovPlayerController();
        IntantiatePowerUp();
    }
    void IntantiatePowerUp() {
        // Set powerup indicator position to beneath player
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.6f, 0);
    }
    // If Player collides with powerup, activate powerup
    void MovPlayerController() {
        // Add force to player in direction of the focal point (and camera)
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed * Time.deltaTime);
        playerRb.AddForce(focalPoint.transform.right * horizontalInput * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space)) {
            speed = 1000;
            dust.Play();
            playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed * Time.deltaTime);
            playerRb.AddForce(focalPoint.transform.right * verticalInput * speed * Time.deltaTime);
            dust.Stop();
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Powerup")) {
            Destroy(other.gameObject);
            hasPowerup = true;
            powerupIndicator.SetActive(true);
        }
    }

    // Coroutine to count down powerup duration
    IEnumerator PowerupCooldown() {
        yield return new WaitForSeconds(powerUpDuration);
        hasPowerup = false;
        powerupIndicator.SetActive(false);
    }

    // If Player collides with enemy
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Enemy")) {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.gameObject.transform.position - transform.position;

            if (hasPowerup) // if have powerup hit enemy with powerup force
            {
                enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
            } else // if no powerup, hit enemy with normal strength 
              {
                enemyRigidbody.AddForce(awayFromPlayer * normalStrength, ForceMode.Impulse);
            }
            if (other.gameObject.CompareTag("Powerup")) {
                Destroy(other.gameObject);
                hasPowerup = true;
                powerupIndicator.SetActive(true); // Activa el indicador del potenciador
                StartCoroutine(PowerupCooldown()); // Inicia la corrutina para gestionar la duraci�n del potenciador
            }

        }
    }


}
