using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaManager : MonoBehaviour {
    public static LoadAndSwitch Instance;

    public GameObject panel;// ponerlo en donde dice su nombre  

    public bool gameIsPaused; //mi booleano no contiene nada para hacer asi manipular en mis condicionales lo que ocupo en su momento y sin confundirme

    void Update() { // Cada vez que el usuario apriete el boton scpae por 1era vez se pone en pausa, la 2nda no y accede a la funcion de pausa 
        if (Input.GetKeyDown(KeyCode.Escape)) {
            gameIsPaused = !gameIsPaused;
            pauseGame();
        }
    }
    public void pauseGame() {//si se apreto la 1era vez, el timepo se detiene a zero, el panel se activa y sera cierto, si no accede a la funcion resume
        if (gameIsPaused) {
            Time.timeScale = 0f;
            panel.SetActive(true);
        } else {
            resumeGame();
        }
    }
    public void resumeGame() {// Cuando se active resume si no esta activo el panel , el tiempo empieza a correr en 1 segundo++
        Time.timeScale = 1f;
        panel.SetActive(false);
    }

    public void Reiniciar(string sceneName) {//se reinicia el tiempo desde el 1er segundo,instancio o llamo a mi script y cambio la escena y en Inspector coloco cual
        Time.timeScale = 1;
        LoadAndSwitch.Instance.sceneSwitch(sceneName);
    }

    public void returnMainMenu() {//hace lo mismo que el anteior pero llamo en vez al Menu en vez de poner un nombre en el Inspector 
        Time.timeScale = 1;
        LoadAndSwitch.Instance.sceneSwitch("Menu");
    }

    public void exitGame() {//me salgo del juego, quito la app , no se si ponga el boton a este al final 
        Application.Quit();
    }
}
