using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cube : MonoBehaviour {
    public MeshRenderer Renderer;
    public Material material;
    public float speed = 4.5f;
    //public float time;
    //private Color[] colors = new Color[] { Color.green, Color.red, Color.blue };
    // int i = 0;
    // public GameObject cube;

    void Start() {
        materialsColor();
        attachPosScale();
        // invokeCube();
    }

    void Update() {
        movCube();

    }
    //public void invokeCube() {
    //    InvokeRepeating("Cube", time, 1.5f);
    //}
    public void movCube() {
        transform.Rotate(1.0f * Time.deltaTime, 4.0f, 5.0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void attachPosScale() {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
    }
    public void materialsColor() {
        material = Renderer.material;
        // material.color = Random.ColorHSV;
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        // cube.GetComponent<MeshRenderer>().material.color = Random.ColorHSV;


        //while (true) {
        //    GetComponent<Renderer>().material.color = colors[i];
        //    i++;

        //    if (i == colors.Length) {
        //        i = 0;
        //    }


        //}
    }
}
