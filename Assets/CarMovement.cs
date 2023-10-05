using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed;

    public Rigidbody rb1, rb2;

    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - rb1.transform.position;
    }

    private void Update()
    {


        if (Input.GetAxis("Horizontal") > 0.5f)
        {
            rb1.transform.localRotation = Quaternion.Euler(0,45,0);
            rb2.transform.localRotation = Quaternion.Euler(0, 45, 0);

        }
        else if (Input.GetAxis("Horizontal") < -0.5f)
        {
            rb1.transform.localRotation = Quaternion.Euler(0, -45, 0);
            rb2.transform.localRotation = Quaternion.Euler(0, -45, 0);

        }
        else
        {
            rb1.transform.localRotation = Quaternion.identity;
            rb2.transform.localRotation = Quaternion.identity;

        }
        rb1.velocity = rb1.transform.right * -speed * Input.GetAxis("Vertical");
        rb2.velocity = rb2.transform.right * -speed * Input.GetAxis("Vertical");
        transform.position = rb1.transform.position + offset;
    }
}
