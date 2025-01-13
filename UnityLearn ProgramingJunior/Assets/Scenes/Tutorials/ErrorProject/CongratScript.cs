using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CongratScript : MonoBehaviour {
    public ParticleSystem SparksParticles; // Vincula el sistema de partículas desde el Editor.
    public TextMeshProUGUI textMeshPro;   // Vincula el componente TextMeshProUGUI desde el Editor.

    private List<string> TextToDisplay;  // Lista de textos para mostrar.
    public float RotatingSpeed = 1.0f;  // Velocidad configurable desde el Editor.
    private float TimeToNextText;       // Control del tiempo entre cambios de texto.
    private int CurrentText;            // Índice actual del texto a mostrar.

    void Start() {
        // Inicializar variables.
        TimeToNextText = 0.0f;
        CurrentText = 0;

        // Inicializar lista de textos.
        TextToDisplay = new List<string> { "Congratulations!", "All Errors Fixed" };

        // Validar referencias.
        if (textMeshPro == null) {
            Debug.LogError("TextMeshProUGUI no asignado en el Inspector.");
            return;
        }

        if (SparksParticles == null) {
            Debug.LogError("ParticleSystem no asignado en el Inspector.");
            return;
        }

        // Mostrar el primer texto y activar partículas.
        textMeshPro.text = TextToDisplay[0];
        SparksParticles.Play();
    }

    void Update() {
        // Incrementar tiempo y cambiar texto según el temporizador.
        TimeToNextText += RotatingSpeed * Time.deltaTime;

        if (TimeToNextText > 1.5f) {
            TimeToNextText = 0.0f; // Reiniciar temporizador.

            // Avanzar al siguiente texto.
            CurrentText++;
            if (CurrentText >= TextToDisplay.Count) {
                CurrentText = 0; // Reiniciar índice si supera la cantidad de textos.
            }

            // Actualizar el texto mostrado.
            textMeshPro.text = TextToDisplay[CurrentText];
        }
    }
}
