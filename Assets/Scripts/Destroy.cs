using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is not used. (But I want to keep it because it works. :) )

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) //it does not work if there is no rigidbody
    {
        Destroy(collision.gameObject);
    }
}
