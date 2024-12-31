using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour {
    [SerializeField] float speedPlane;
    [SerializeField] GameObject m_gameObject;
    [SerializeField] float m_speedUp;
    [SerializeField] float m_speedDown;

    void Start() {

    }
    void Update() {
        MovementPlane();
    }

    void MovementPlane() {
        transform.position += transform.forward * speedPlane * Time.deltaTime;//para mover en el eje Y el avion
        if (Input.anyKeyDown) {

            switch (GetPressedKey()) {
                case KeyCode.W:
                    transform.position += transform.up * speedPlane * m_speedUp * Time.deltaTime;//para subir 
                    // m_speedUp += Time.deltaTime;
                    break;
                case KeyCode.S:
                    transform.position += -transform.up * speedPlane * m_speedDown * Time.deltaTime;//para bajar
                    // m_speedDown += Time.deltaTime;
                    break;
            }
        }
    }
    KeyCode GetPressedKey() {
        foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode))) {
            if (Input.GetKeyDown(keyCode)) {
                return keyCode;
            }
        }
        return KeyCode.None;
    }
}
