using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {
    public float speed = 120.0f;
 
    private void FixedUpdate() {
        movForward();
    }
    public void movForward() {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
