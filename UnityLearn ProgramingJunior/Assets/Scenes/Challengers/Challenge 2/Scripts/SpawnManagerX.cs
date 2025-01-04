using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour {
    public GameObject[] ballPrefabs;

    [SerializeField] float spawnLimitXLeft;
    [SerializeField] float spawnLimitXRight;
    [SerializeField] float spawnPosY;
    [SerializeField] float spawnPosZ;

    // private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start() {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall() {
        spawnInterval = Random.Range(3f, 5f);
        Invoke("SpawnRandomBall", spawnInterval); 

        int randomIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosZ, spawnPosY);
        Instantiate(ballPrefabs[randomIndex], spawnPosition, ballPrefabs[randomIndex].transform.rotation);
    }

}
