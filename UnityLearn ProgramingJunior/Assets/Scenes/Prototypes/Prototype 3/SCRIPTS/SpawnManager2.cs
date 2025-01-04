using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour {

    [SerializeField] private PlayerController2 playerController;

    public GameObject obstaculePrefab;

    //public float startDelay = 2;
    public float repeatRate = 2;
    void Start() {
        Invoke("Obstacle", repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController2>();
    }

    // Update is called once per frame
    void Update() {
        invokingObstacules();
    }
    void invokingObstacules() {
        if (playerController.gameOver == false) {
            Vector3 spawnPosition = new Vector3(0, 0, 25);
            Instantiate(obstaculePrefab, spawnPosition, obstaculePrefab.transform.rotation);
        }
    }
}
