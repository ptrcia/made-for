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
        sunRotation = sun.transform.rotation.x;

        //Debug.Log(sunRotation);

        if(sunRotation < -0.2)
        {
            carLight.enabled = true;   
        }
        else if(sunRotation < 0.3)
        {
            carLight.enabled = false;
        }
    }  
}
