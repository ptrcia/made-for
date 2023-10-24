using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is not used. (But I want to keep it because it works. :) )

public class RoadMovement : MonoBehaviour
{
    //This script creates the illusion that the car is moving along the road,
    //but what we do behind the scenes is to move the texture backwards.
    //back Z positive, down, forward, left X positive
    [SerializeField] float ScrollX = 1f; //If I value both, the movement is diagonal.
    [SerializeField] float ScrollY = 0;

    void Update ()
    {
        float OffsetX = Time.time * ScrollX;
        float OffsetY = Time.time * ScrollY;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
    }
}
