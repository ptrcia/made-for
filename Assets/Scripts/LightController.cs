using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    //I have control over the rotation of the sun 
    [SerializeField] float dayLength;
    float rotationSpeed;

    void Update()
    {
        rotationSpeed = Time.deltaTime / dayLength;
        transform.Rotate(rotationSpeed, 0, 0); 
        //I know the movement is simple, that it just rotate in one axis but :)
    }
}