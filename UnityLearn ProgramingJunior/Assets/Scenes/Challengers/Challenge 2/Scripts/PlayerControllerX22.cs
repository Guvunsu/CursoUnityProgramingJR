using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX22 : MonoBehaviour {
    public GameObject dogPrefab;

    [SerializeField] float speedAxisZ;
    // Update is called once per frame
    void Update() {
        instanceDog();
    }
    void instanceDog() {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
 
}
