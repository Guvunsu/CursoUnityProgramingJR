using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesPr4 : MonoBehaviour {
    public GameObject enemyPrefab;
    Vector3 randomPos;
    float enemySpawnxPos;
    float enemySpawnzPos;
    float spawnRange = 9.0f;

    void Start() {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update() {

    }
    private Vector3 GenerateSpawnPosition() {
        enemySpawnxPos = Random.Range(-spawnRange, spawnRange);
        enemySpawnzPos = Random.Range(-spawnRange, spawnRange);
        randomPos = new Vector3(enemySpawnxPos, 0, enemySpawnzPos);
        return randomPos;
    }
}
