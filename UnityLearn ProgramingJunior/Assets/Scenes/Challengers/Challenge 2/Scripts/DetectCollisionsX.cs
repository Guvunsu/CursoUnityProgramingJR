using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Colisión con: " + other.gameObject.name);
        if (other.gameObject.CompareTag("Dog")) {
            Debug.Log("¡Pelota tocó un perro!");
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }
}
