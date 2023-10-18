using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Patricia Gracia Artero
//Free to use
public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) //it does not work if thtere is no rigidbidy
    {
        Destroy(collision.gameObject);
    }
}
