using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerItems : MonoBehaviour {
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    private int score;
    int index;
    private float spawnRate = 1.0f;
    void Start() {
        StartCoroutine(SpawnTargetz());
        UpdateScore(0);
        score = 0;
        scoreText.text = "Score" + score;
    }

    // Update is called once per frame
    void Update() {

    }

    private void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Score" + score;
    }
    IEnumerator SpawnTargetz() {
        while (true) {
            yield return new WaitForSeconds(spawnRate);
            index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
}
