using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Patricia Gracia Artero
//Free to use
public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) //no funciona no tienen rigidbody
    {
        Destroy(collision.gameObject);
    }
}
