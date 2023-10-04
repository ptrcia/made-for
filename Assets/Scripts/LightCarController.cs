using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightCarController : MonoBehaviour
{
    public Light carLight;
    public Transform sun;
    public float sunRotation;

    void Awake()
    {
        carLight = GetComponent<Light>();
    }
    void Update()
    {
        sunRotation = sun.transform.localEulerAngles.x;

        //Debug.Log(sunRotation);

        if(sunRotation > 0 && sunRotation < 180)
        {
            carLight.enabled = false;   
        }
        else
        {
            carLight.enabled = true;
        }
    }  
}
