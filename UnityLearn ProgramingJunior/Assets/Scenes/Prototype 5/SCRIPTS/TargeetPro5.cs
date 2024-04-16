using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargeetPro5 : MonoBehaviour {

    //public ParticleSystem explosionParticle;

    //public int pointValue;

    //private GameManagerItems gameManagerItems;
    //private Rigidbody targetPro5;

    //private float minSpeed = 12;
    //private float maxSpeed = 16;
    //private float maxTorque = 10;
    //private float xRange = 4;
    //private float ySpawnPos = -6;



    //void Start() {

    //    instanceGetsComponents();

    //    gameManagerItems = GameObject.Find("GameOver").GetComponent<GameManagerItems>();

    //    targetPro5.AddForce(RandomForce(), ForceMode.Impulse);

    //    targetPro5.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

    //    transform.position = RandomSpawnPos();
    //}
    //void Update() {

    //}



    //private void OnMouseDown() {
    //    if (gameManagerItems.isGameActive) {
    //        Destroy(gameObject);
    //        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
    //        gameManagerItems.UpdateScore(pointValue);//esta la funcion en GameManagerItems
    //    }
    //}
    ////estos 2 errores ni idea del porque aunque me expliquen
    //private void OnTriggerEnter(Collider other) {
    //    Destroy(gameObject);

    //    if (!gameObejct.CompareTag("Bad")) {
    //        gameManagerItems.gameOverTextMeshPro();
    //    }

    //}
    //// ni puta idea del porque sale mal esto 
    //Vector3 RandomForce() {
    //    return Vector3.up * Random.Range(minSpeed, maxTorque);
    //}
    //float RandomTorque() {
    //    return Random.Range(-maxTorque, maxTorque);
    //}
    //Vector3 RandomSpawnPos() {
    //    return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    //}
    //void instanceGetsComponents() {
    //    targetPro5 = GetComponent<Rigidbody>();
    //}
}



