using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManLabMyGame : MonoBehaviour {

    public Rigidbody[] enemies;
    public Rigidbody superPoder;

    [SerializeField] float zEnemiesSpawn = 4.35f;
    [SerializeField] float xSpawnRange = 4.35f;
    [SerializeField] float zSuperPoderRange = 6.40f;

    [SerializeField] float superpoderSpawnTime = 5.0f;
    [SerializeField] float enemySpawnTime = 1.0f;
    [SerializeField] float starDelay = 1.0f;

    Vector3 spawnPositions;

    [SerializeField] float randomX;
    [SerializeField] float randomZ;
    [SerializeField] int randomIndex;
    [SerializeField] float ySpawn = 0.75f;

    void Start() {
        // EnemiesSpawnRandom();
        invokeRepeting();
        // SuperpoderSpawnRandom();
    }
    void invokeRepeting() {
        InvokeRepeating("EnemiesSpawnRandom", starDelay, enemySpawnTime);
        InvokeRepeating("SuperpoderSpawnRandom", starDelay, superpoderSpawnTime);
    }
    void EnemiesSpawnRandom() {
        randomX = Random.Range(-xSpawnRange, xSpawnRange);
        randomZ = Random.Range(-zSuperPoderRange, zSuperPoderRange);
        randomIndex = Random.Range(0, enemies.Length);

        spawnPositions = new Vector3(randomX, ySpawn, zEnemiesSpawn);

        Instantiate(enemies[randomIndex], spawnPositions, enemies[randomIndex].gameObject.transform.rotation);
        Debug.Log("Enemigo instanciado: " + enemies + " en posición " + spawnPositions);
    }
    void SuperpoderSpawnRandom() {
        randomX = Random.Range(-xSpawnRange, xSpawnRange);
        randomZ = Random.Range(-zSuperPoderRange, zSuperPoderRange);
        //randomIndex = Random.Range(0, 0);
        spawnPositions = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(superPoder, spawnPositions, superPoder.gameObject.transform.rotation);
    }
}
