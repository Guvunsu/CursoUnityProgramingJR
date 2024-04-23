using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManLabMyGame : MonoBehaviour {



    public Rigidbody[] enemies;
    public Rigidbody superPoder;

    private float zEnemiesSpawn = 4.35f;              //cambiar los valores / change the value later
    private float xSpawnRange = 4.35f;
    private float zSuperPoderRange = 6.40f;

    private float superpoderSpawnTime = 5.0f;
    private float enemySpawnTime = 1.0f;
    private float starDelay = 1.0f;

    Vector3 spawnPositions;

    float randomX;
    float randomZ;
    int randomIndex;
    float ySpawn = 0.75f;



    void Start() {
        EnemiesSpawnRandom();
        invokeRepeting();
        SuperpoderSpawnRandom();
    }

    void Update() {

    }



    void EnemiesSpawnRandom() {
        randomX = Random.Range(-xSpawnRange, xSpawnRange);
        randomIndex = Random.Range(0, enemies.Length);

        spawnPositions = new Vector3(randomX, ySpawn, zEnemiesSpawn);

        Instantiate(enemies[randomIndex], spawnPositions, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SuperpoderSpawnRandom() {
        randomX = Random.Range(-xSpawnRange, xSpawnRange);
        randomZ = Random.Range(-zSuperPoderRange, zSuperPoderRange);
        spawnPositions = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(superPoder, spawnPositions, superPoder.gameObject.transform.rotation);
    }
    void invokeRepeting() {
        InvokeRepeating("spawnRandomEnemy", starDelay, enemySpawnTime);
        InvokeRepeating("spawnSuperPoder", starDelay, superpoderSpawnTime);
    }
}
