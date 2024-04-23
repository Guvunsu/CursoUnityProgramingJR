using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadAndSwitch : MonoBehaviour {
    public static SceneManager Instance;

    public GameObject losePanel;

    public bool losePanelIsOpen = true;
    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(this);
            Destroy(gameObject);
        } else {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

    }

    public void sceneSwitch(string sceneName) {
        SceneManager.instance.LoadScene(sceneName);
        losePanelIsOpen = false;
    }
}
