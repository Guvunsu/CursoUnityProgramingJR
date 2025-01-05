using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

    [SerializeField] Rigidbody p1RB;
    private Animator playerAnimator;
    [SerializeField] ParticleSystem dirtparticleSystem;
    [SerializeField] ParticleSystem smokeparticleSystem;
    [SerializeField] ParticleSystem xploxionParticule;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip crashSound;
    [SerializeField] AudioSource playerAudio;


    [SerializeField] float jumpForce;
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

        if (Input.GetKeyDown(KeyCode.Space) && isonGround && !gameOver) {
            p1RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isonGround = false;
            playerAnimator.SetTrigger("Jump_trig");
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            dirtparticleSystem.Stop();
        }

    }
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {

            isonGround = true;
            dirtparticleSystem.Play();

        } else if (collision.gameObject.CompareTag("Obstacle")) {
            Debug.Log("GameOver");
            gameOver = true;
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            xploxionParticule.Play();
            dirtparticleSystem.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            smokeparticleSystem.Play();
        }
    }

}
