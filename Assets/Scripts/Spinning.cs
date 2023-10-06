using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpinningSymbol : MonoBehaviour
{
    public int speed = 10;
    private void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
    }
}
