using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesPr4 : MonoBehaviour {
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    Vector3 randomPos;
    public int enemyCount;
    float enemySpawnxPos;
    float enemySpawnzPos;
    float spawnRange = 9.0f;
    public int waveNumber = 1;

    void Start() {
        SpawnEnemyWave(waveNumber);
        instanciar();
    }

    // Update is called once per frame
    void Update() {
        numbnersOfEnemies();
        instanciar();
    }
    void instanciar() {
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }
    void SpawnEnemyWave(int enemiesToSpawn) {
        for (int i = 0; i < enemiesToSpawn; i++) ;
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }
    void numbnersOfEnemies() {
        enemyCount = FindObjectsOfType<EnemyFollowMe>().Length;
        if (enemyCount == 0) {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }
    private Vector3 GenerateSpawnPosition() {
        enemySpawnxPos = Random.Range(-spawnRange, spawnRange);
        enemySpawnzPos = Random.Range(-spawnRange, spawnRange);
        randomPos = new Vector3(enemySpawnxPos, 0, enemySpawnzPos);
        return randomPos;
    }
}
