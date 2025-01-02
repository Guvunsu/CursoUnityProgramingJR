using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {
    private float topBound = 15f;
    private float lowerBound = -1f;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        destructionPrefabs();
    }
    public void destructionPrefabs() {
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) {
            Debug.Log("gameover");
            Destroy(gameObject);
        }

    }
}
