using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBGandFloor : MonoBehaviour {
    private PlayerController2 playerController;
    [SerializeField] float speed = 30.0f;
    [SerializeField] float leftBound;
    // Start is called before the first frame update
    void Start() {
        playerController = GameObject.Find("Player").GetComponent<PlayerController2>();
    }

    // Update is called once per frame
    void Update() {
        if (playerController.gameOver == false) {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}
