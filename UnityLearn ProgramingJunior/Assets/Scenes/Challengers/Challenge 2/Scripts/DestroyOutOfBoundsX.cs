using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour {
    [SerializeField] float leftLimit;
    [SerializeField] float bottomLimit;

    // Update is called once per frame
    void Update() {
        // Destroy balls if y position is less than bottomLimit
        if (transform.position.y < bottomLimit) {
            Destroy(gameObject);
        }
       // Destroy dogs if x position less than left limit
       else if (transform.position.x < leftLimit) {
            Destroy(gameObject);
        }

    }
}
