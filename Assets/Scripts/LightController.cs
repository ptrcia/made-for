using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Patricia Gracia Artero
//Free to use

public class LightController : MonoBehaviour
{
    //I hace control over the rotation of the sun 
    [SerializeField]
    private float dayLength;
    float rotationSpeed;

    void Update()
    {
        rotationSpeed = Time.deltaTime / dayLength;
        transform.Rotate(rotationSpeed, 0, 0); 
        //I know the movement is simple, that it just rotate in one axis but :)
    }
}