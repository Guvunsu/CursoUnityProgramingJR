using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftObstacule : MonoBehaviour {
    private PlayerController2 playerController;
    [SerializeField] float speed = 10.0f;
    [SerializeField] float leftBound = 17;
    // Start is called before the first frame update
    void Start() {
        playerController = GameObject.Find("Player").GetComponent<PlayerController2>();
    }

    // Update is called once per frame
    void Update() {
        if (playerController.gameOver == false) {
            transform.Translate(Vector3.forward *Time.deltaTime * speed);
        }if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
    }
}
