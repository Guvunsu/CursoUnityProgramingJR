using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    private float speed = 30.0f;
    private PlayerController2 playerController;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start() {
        playerController = GameObject.Find("Player").GetComponent<PlayerController2>();
    }

    // Update is called once per frame
    void Update() {
        if (playerController.gameOver == false) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) {
                Destroy(gameObject);
            }
        }
    }
}
