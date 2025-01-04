using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour {

    private PlayerController2 playerController;
    public GameObject obstaculePrefab;

    [SerializeField] float repeatRate = 2;
    [SerializeField] float startDelay = 2;

    void Start() {
        playerController = GameObject.Find("Player").GetComponent<PlayerController2>();
        InvokeRepeating("invokingObstacules", startDelay, repeatRate);

    }
    void invokingObstacules() {
        if (!playerController.gameOver) {
            Vector3 spawnPosition = new Vector3(-8, 0, 0);
            Instantiate(obstaculePrefab, spawnPosition, obstaculePrefab.transform.rotation);
            //gameObject.SetActive(obstaculePrefab);
            //Destroy(obstaculePrefab, 6f);
        }
    }
}
