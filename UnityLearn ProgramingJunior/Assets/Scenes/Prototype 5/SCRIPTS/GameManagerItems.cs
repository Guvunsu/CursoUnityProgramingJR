using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerItems : MonoBehaviour {


    public TextMeshProUGUI gameOverText;
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public Button restartButton;
    public GameObject titleScreen;//no me quiere sallir para el gameobject game manager


    int index;

    private int score;
    private float spawnRate = 1.0f;

    public bool isGameActive;

    void Start() {
        StartGame(difficulty);//corregir esto
    }
    void Update() {

    }

    public void StartGame(int difficulty) {
        isGameActive = true;
        score = 0;
        spawnRate /= difficulty;
        StartCoroutine(SpawnTargetz());
        UpdateScore(0);
        gameOverTextMeshPro();
    }
    private void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Score" + score;
    }

    IEnumerator SpawnTargetz() {
        while (isGameActive) {
            yield return new WaitForSeconds(spawnRate);
            index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void gameOverTextMeshPro() {

        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        titleScreen.gameObject.SetActive(false);
    }
}
