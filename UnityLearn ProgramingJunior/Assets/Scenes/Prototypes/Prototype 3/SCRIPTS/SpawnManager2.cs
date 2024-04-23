using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour {

    [SerializeField] private PlayerController2 playerController;

    public GameObject obstaculePrefab;

    private new Vector3 spawnPosition;

    public float startDelay = 2;
    public float repeatRate = 2;
    void Start() {
        InvokeRepeating("Obstacle", startDelay, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController2>();
    }

    // Update is called once per frame
    void Update() {
        invokingObstacules();
    }
    void invokingObstacules() {
        if (playerController.gameOver == false) {
            spawnPosition = new Vector3(25, 0, 0);
            Instantiate(obstaculePrefab, spawnPosition, obstaculePrefab.transform.rotation);
        }
    }
}
