using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCarController : MonoBehaviour
{
    //The lights of the car changes with the posicion of the sun 
     [SerializeField] Light carLight;
     [SerializeField] Transform sun;
     [SerializeField] float sunRotation;

     void Awake()
     {
         carLight = GetComponent<Light>();
     }
     void Update()
     {
         sunRotation = sun.transform.localEulerAngles.x; //localEulerAngels to transform the nombers from randomness to something manageable

         if(sunRotation > 0 && sunRotation < 90)
         {
             carLight.enabled = false;   
         }
         else
         {
             carLight.enabled = true;
         }

         //Debug.Log("Ángulo de rotación alrededor del eje X: " + sunRotation + " grados");
     }  

}
