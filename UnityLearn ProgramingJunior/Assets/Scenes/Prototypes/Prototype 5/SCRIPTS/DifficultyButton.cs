using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour {

    private Button button;
    private GameManagerItems gameManagerItems;

    public int difficulty;

    void Start() {
        button = GetComponent<Button>();
        gameManagerItems = GameObject.Find("GameManager").GetComponent<GameManagerItems>();
        button.onClick.AddListener(SetDifficulty);
    }
    void SetDifficulty() {
        Debug.Log(gameObject.name + "was clicked");
        gameManagerItems.StartGame(difficulty);
    }
}
