using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Patricia Gracia Artero
//Free to use

public class LightController : MonoBehaviour
{
    public float dayLength;
    float rotationSpeed;

    void Update()
    {
        rotationSpeed = Time.deltaTime / dayLength;
        transform.Rotate(rotationSpeed, 0, 0);
    }
}