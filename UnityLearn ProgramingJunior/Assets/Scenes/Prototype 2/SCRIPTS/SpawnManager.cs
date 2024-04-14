using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject[] animalsPrefabs;
    public float spawnxRange;
    public float spawnzRange;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    void Start() {
        invoke();
    }

    // Update is called once per frame
    void Update() {
        arrayAnimals();
    }
    public void arrayAnimals() {

        Vector3 spawnPos = new Vector3(Random.Range(spawnxRange, -spawnxRange), 0, spawnzRange);
        int animalIndex = Random.Range(0, animalsPrefabs.Length);

        Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);
    }

    public void invoke() {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }


}
