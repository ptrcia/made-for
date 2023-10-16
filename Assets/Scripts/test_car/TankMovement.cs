using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float turnSpeed;
    [SerializeField] AudioClip idleClip, drivingClip;
                               
    float vertical, horizontal;
    Rigidbody rb;

    AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        InputPlayer();
        AudioEngine();
    }
    void InputPlayer()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Move();
        Turn();
    }
    void Move()
    {
        //El movimiento que quiero que gaga
        Vector3 movement = transform.forward * vertical * speed * Time.deltaTime;

        //Aplicar el movimiento
        rb.MovePosition(transform.position + movement);
    }
    void Turn()
    {
        float turn = horizontal * turnSpeed * Time.deltaTime;

        //quaternos es como unity entiende los gradoa, con 4 ejes.
        //En esta sentencia lo transformarmos en grados normales con EULER
        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);
        rb.MoveRotation(transform.rotation * turnRotation);
    }
    void AudioEngine()
    {
        if(vertical!=0 || horizontal !=0) //si el vertical es un valor, se mueve
        {
            if (audioSource.clip != drivingClip)
            {
                audioSource.clip = drivingClip;
                audioSource.Play();
            }
        }else{

            if (audioSource.clip != idleClip)
            {
                audioSource.clip = idleClip;
                audioSource.Play();
            }
        }
    }
}
