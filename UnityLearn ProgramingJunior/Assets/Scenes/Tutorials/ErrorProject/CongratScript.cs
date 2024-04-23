using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CongratScript : MonoBehaviour {
    //public TextMesh Text;
    public ParticleSystem SparksParticles;

    private List<string> TextToDisplay;
    private TextMeshProUGUI textMeshPro;


    private float RotatingSpeed;
    private float TimeToNextText;

    private int CurrentText;

    // Start is called before the first frame update
    void Start() {
        TimeToNextText = 0.0f;
        CurrentText = 0;

        RotatingSpeed = 1.0f;

        TextToDisplay.Add("Congratulation");
        TextToDisplay.Add("All Errors Fixed");

        textMeshPro.text = TextToDisplay[0];

        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update() {
        TimeToNextText += RotatingSpeed *Time.deltaTime;//hice esto

        if (TimeToNextText > 1.5f) {
            TimeToNextText = 0.0f;

            CurrentText++;
            if (CurrentText >= TextToDisplay.Count) {
                CurrentText = 0;


                textMeshPro.text = TextToDisplay[CurrentText];
            }
        }
    }
}