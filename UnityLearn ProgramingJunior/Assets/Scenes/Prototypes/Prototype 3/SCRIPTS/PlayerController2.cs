using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

    [SerializeField] Rigidbody p1RB;
    [SerializeField] Animator playerAnimator;
    [SerializeField] ParticleSystem dirtparticleSystem;
    [SerializeField] ParticleSystem smokeparticleSystem;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip crashSound;
    [SerializeField] AudioSource playerAudio;


    [SerializeField] float jumpForce = 4.0f;
    [SerializeField] float gravityModifier;
    [SerializeField] bool isonGround = true;
    [NonSerialized] public bool gameOver = false;

    void Start() {
        p1RB = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update() {
        jump();

    }
    public void jump() {

        if (Input.GetKeyDown(KeyCode.M) && isonGround && !gameOver) {
            dirtparticleSystem.Stop();
            p1RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isonGround = false;
            playerAnimator.SetTrigger("Jump_trig");
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

    }
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {

            isonGround = true;
            dirtparticleSystem.Play();

        } else if (collision.gameObject.CompareTag("Obstacle")) {
            //xploxionParticule.Play();
            dirtparticleSystem.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            Debug.Log("GameOver");
            gameOver = true;
            playerAnimator.SetBool("Dead_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            smokeparticleSystem.Play();
        }
    }

}
