using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargeetPro5 : MonoBehaviour {

    public ParticleSystem explosionParticle;

    private GameManagerItems gameManagerItems;
    private Rigidbody targetPro5;

    public int pointValue;

    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;



    void Start() {
        targetPro5 = GetComponent<Rigidbody>();
        if (targetPro5 == null) {
            Debug.LogError("No se encontró Rigidbody en el objeto.");
        }

        GameObject gameOverObject = GameObject.Find("GameOver");
        if (gameOverObject != null) {
            gameManagerItems = gameOverObject.GetComponent<GameManagerItems>();
        } else {
            Debug.LogError("GameOver GameObject no encontrado.");
        }

        targetPro5.AddForce(RandomForce(), ForceMode.Impulse);
        targetPro5.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }
    void Update() {

    }



    private void OnMouseDown() {
        if (gameManagerItems.isGameActive) {
      
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManagerItems.UpdateScore(pointValue);//esta la funcion en GameManagerItems
        }
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Colisión detectada con: " + other.gameObject.name);
        Destroy(gameObject);

        if (other.CompareTag("Bad")) {
            gameManagerItems.gameOverTextMeshPro();
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



