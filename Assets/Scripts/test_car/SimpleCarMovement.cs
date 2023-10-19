
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Patricia Gracia Artero
//Free to use

public class SimpleCarMovement : MonoBehaviour
{
    [SerializeField] float speed = 10.0f, turnSpeed = 100.0f;
    float vertical, horizontal;
    public Transform rightWheel, leftWheel;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        InputPlayer();
    }

    void FixedUpdate()
    {
        Move();
        Turn();
        TurningWheels();
    }
    void InputPlayer()
    {
        vertical = Input.GetAxis("Vertical"); // Vertical axis (W or S or arrow keys up/down)
        horizontal = Input.GetAxis("Horizontal"); // Horizontal axis (A or D or arrow keys left/right)
    }

    void Move()
    {

        //the movement i want it to do
        Vector3 movement = transform.forward * vertical * speed * Time.deltaTime;

        //apply movement
        rb.MovePosition(transform.position + movement);
    }

    void Turn()
    {
        float turn = horizontal * turnSpeed * Time.deltaTime;
        //euler to transform 
        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);
        //apply rotation
        rb.MoveRotation(transform.rotation * turnRotation);
    }
    void TurningWheels() //rotaion of the wheels to get the feeling
    {
        if (horizontal > 0.5f)
        {
            rightWheel.transform.localRotation = Quaternion.Euler(0, 45, 0);
            leftWheel.transform.localRotation = Quaternion.Euler(0, 45, 0);
        }
        else if (horizontal < -0.5f)
        {
            rightWheel.transform.localRotation = Quaternion.Euler(0, -45, 0);
            leftWheel.transform.localRotation = Quaternion.Euler(0, -45, 0);
        }
        else
        {
            rightWheel.transform.localRotation = Quaternion.identity;
            leftWheel.transform.localRotation = Quaternion.identity;
        }
    }
}