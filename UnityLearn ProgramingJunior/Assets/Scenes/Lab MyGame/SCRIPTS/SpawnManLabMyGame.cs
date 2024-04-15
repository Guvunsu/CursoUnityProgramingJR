using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManLabMyGame : MonoBehaviour {



    public Rigidbody[] enemies;
    public Rigidbody superPoder;

    private float zEnemiesSpawn = 4.35f;              //cambiar los valores / change the value later
    private float xSpawnRange = 4.35f;
    private float zSuperPoderRange = 6.40f;

    Vector3 spawnPositions;

    float randomX;
    int randomIndex;
    float ySpawn = 0.75f;



    void Start() {
        EnemiesSpawn();
    }

    void Update() {

    }



    void EnemiesSpawn() {
        randomX = Random.Range(-xSpawnRange, xSpawnRange);
        randomIndex = Random.Range(0, enemies.Length);

        spawnPositions = new Vector3(randomX, ySpawn, zEnemiesSpawn);

        Instantiate(enemies[randomIndex], spawnPositions, enemies[randomIndex].gameObject.transform.rotation);
    }



}
