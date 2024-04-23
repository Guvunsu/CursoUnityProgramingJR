using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

    public void startGame() {
        LoadAndSwitch.Instance.sceneSwitch("Gameplay");
    }

    public void exitGame() {
        Application.Quit();
    }
}
