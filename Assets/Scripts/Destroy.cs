using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision) //no funciona no tienen rigidbody
    {
        Destroy(collision.gameObject);
    }
}
