using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour {
    public GameObject[] ballPrefabs;

    [SerializeField] float spawnLimitXLeft;
    [SerializeField] float spawnLimitXRight;
    [SerializeField] float spawnPosY;
    [SerializeField] float spawnPosZ;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start() {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall() {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight),spawnPosZ, spawnPosY);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[2].transform.rotation);
    }

}
