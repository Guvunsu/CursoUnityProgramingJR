using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargeetPro5 : MonoBehaviour {

    public ParticleSystem explosionParticle;
    private GameManagerItems gameManager;
    private Rigidbody targetPro5;

    [SerializeField] int pointValue;
    [SerializeField] float minSpeed = 12;
    [SerializeField] float maxSpeed = 16;
    [SerializeField] float maxTorque = 10;
    [SerializeField] float xRange = 4;
    [SerializeField] float ySpawnPos = -6;

    void Start() {
        targetPro5 = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerItems>();
        targetPro5.AddForce(RandomForce(), ForceMode.Impulse);
        targetPro5.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        transform.position = RandomSpawnPos();
    }
    private void OnMouseDown() {
        if (gameManager.isGameActive) {
            //print("me presionan pero no me ejecuto para destruirme amo mio");
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManager.UpdateScore(pointValue);//esta la funcion en GameManagerItems
        }
    }
    private void OnTriggerEnter(Collider other) {
        //Debug.Log("Colisión detectada con: " + other.gameObject.name);
        Destroy(gameObject);
        if (!other.CompareTag("Bad")) {
            gameManager.gameOver();
        }
    }
    Vector3 RandomForce() {
        return Vector3.up * UnityEngine.Random.Range(minSpeed, maxSpeed);
    }
    float RandomTorque() {
        return UnityEngine.Random.Range(-maxTorque, maxTorque);
    }
    Vector3 RandomSpawnPos() {
        return new Vector3(UnityEngine.Random.Range(-xRange, xRange), ySpawnPos);
    }
}



