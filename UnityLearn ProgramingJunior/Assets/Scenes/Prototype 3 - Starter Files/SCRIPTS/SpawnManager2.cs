using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour {
    public GameObject obstaculePrefab;
    private new Vector3 spawnPosi = new Vector3(25, 0, 0);
    public float startDelay = 2;
    public float repeatRate = 2;
    private PlayerController2 playerController;
    void Start() {
        playerController = GameObject.Find("Player").GetComponent<PlayerController2>();
        InvokeRepeating("Obstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update() {

    }
    void InvokingObstacules() {
        if (playerController.gameOver == false) {

            Instantiate(obstaculePrefab, spawnPosi, obstaculePrefab.transform.rotation);
        }
    }
}
