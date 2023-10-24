using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Spins on itself
public class Spinning : MonoBehaviour
{
    [SerializeField] int speed = 10;
    private void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
    }
}
