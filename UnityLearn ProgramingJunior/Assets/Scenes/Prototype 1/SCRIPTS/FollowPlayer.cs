using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void LateUpdate() { // se mueve despues del vehiculo , gracias al lateUpdate que se actrualiza depsues del update 
        // la camara sigue al jugador , añadiendo la psociion del jugador 
        transform.position = player.transform.position + offset;
    }
}
