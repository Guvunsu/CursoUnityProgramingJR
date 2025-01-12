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


    [SerializeField] int index;
    [SerializeField] int score;
    [SerializeField] float spawnRate = 1.0f;

    public bool isGameActive = true;

    void Start() {
        isGameActive = true;
        StartCoroutine(SpawnTargetz());
        score = 0;
        UpdateScore(0);
        gameOverText.gameObject.SetActive(true);
    }
    void Update() {

    }
    IEnumerator SpawnTargetz() {
        while (isGameActive) {
            yield return new WaitForSeconds(spawnRate);
            index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }
    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Score" + score;
    }


    public void gameOverTextMeshPro() {

        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
