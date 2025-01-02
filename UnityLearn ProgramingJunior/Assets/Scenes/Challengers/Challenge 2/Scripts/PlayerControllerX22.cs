using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX22 : MonoBehaviour {
    public GameObject dogPrefab;

    [SerializeField] float speedAxisZ;
    // Update is called once per frame
    void Update() {
        instanceDog();
       // moveDog();
    }
    void instanceDog() {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
    //void moveDog() {
    //    transform.position = new Vector3(0, 0, speedAxisZ);
    //}
    //private void OnTriggerEnter(Collider other) {
    //    if (other.gameObject.CompareTag("Ball") && other.gameObject.CompareTag("Player")) {
    //        Destroy(gameObject);
    //    }
    //}
}
