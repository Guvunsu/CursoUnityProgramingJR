using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake() {
        {
            if (instance == null) {
                //==null todas las tipo clase gameobject de Unity, tu puedes referenciar
                instance = this;
                // busca y selecciona Gamemanager
                DontDestroyOnLoad(gameObject);
                //no destruye un permanente objetivo gameobject cuando carga la escena
            } else {
                Destroy(gameObject);
            }
        }
    }

    public void LoadScene(string sceneName) {// hago una funcion que ara que carque las escenas que yo necesito en su momento, como Menu, los Prototypes, Pausa,etc
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }//escribir lo de UnityEngine.Sce......porque no se porque fue la unica manera que me jalara la cuestion de cargar escena

    internal void sceneSwitch(string v) {// esto son cosas de sugerencias de github con Visual
        throw new NotImplementedException();
    }

    public static implicit operator GameManager(LoadAndSwitch v) {
        throw new NotImplementedException();
    }
}
