using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyFollowMe : MonoBehaviour {
    private GameObject player;
    private Rigidbody enemyRb;
    public float speed = 1.0f;

    void Start() {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update() {
        enemyFollowYou();
    }
    void enemyFollowYou() {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
