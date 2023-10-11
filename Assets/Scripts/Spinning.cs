using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Patricia Gracia Artero
//Free to use

public class Spinning : MonoBehaviour
{
    [SerializeField]
    private int speed = 10;
    private void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
    }
}
