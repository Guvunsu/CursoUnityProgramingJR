using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameManagerItems : MonoBehaviour {

    [SerializeField] TextMeshProUGUI gameOverText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] List<GameObject> targets;
    [SerializeField] Button restartButton;
    [SerializeField] GameObject titleScreen;

    [SerializeField] int index;
    [SerializeField] int score;
    [SerializeField] float spawnRate = 1.0f;

    public bool isGameActive = true;

    IEnumerator SpawnTargetz() {
        while (isGameActive) {
            yield return new WaitForSeconds(spawnRate);
            index = UnityEngine.Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Score" + score;
    }
    public void gameOver() {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);

        isGameActive = false;
    }
    public void RestartGame() {
        Debug.Log("Colisión detectada con el boton: ");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int difficulty) {
        isGameActive = true;
        score = 0;
        spawnRate /= difficulty;
        StartCoroutine(SpawnTargetz());
        UpdateScore(0);
        titleScreen.SetActive(false);
    }
}
