using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour {
    public float speed;
    private Rigidbody enemyRb;
     private GameObject playerGoal;


    // Start is called before the first frame update
    void Start() {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");

    }

    // Update is called once per frame
    void Update() {
        if (playerGoal != null) {
            // Set enemy direction towards player goal and move there
            Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
            // playerGoal.transform.position = new Vector3(lookDirection *speed*Time.deltaTime);
            enemyRb.AddForce(lookDirection * speed * Time.deltaTime, ForceMode.Impulse);
        }


    }

    private void OnCollisionEnter(Collision other) {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal") {
            Destroy(gameObject);
        } else if (other.gameObject.name == "Player Goal") {
            Destroy(gameObject);

        }

    }

}
