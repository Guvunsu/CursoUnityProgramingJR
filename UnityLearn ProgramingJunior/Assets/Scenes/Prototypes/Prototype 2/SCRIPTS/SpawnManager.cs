using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    [SerializeField] GameObject[] animalsPrefabs;
    [SerializeField] float spawnxRange;
    [SerializeField] float spawnzRange;
    [SerializeField] float startDelay;
    [SerializeField] float spawnInterval;
    void Start() {
        invoke();
    }
    void Update() {
        arrayAnimals();
    }
    public void arrayAnimals() {
       // if (Input.GetKeyDown(KeyCode.S)) {
            int animalIndex = Random.Range(0, animalsPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnxRange, spawnxRange), 0, spawnzRange);

            Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);
        //}
    }

    public void invoke() {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }


}
