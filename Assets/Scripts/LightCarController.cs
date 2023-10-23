using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;

//Patricia Gracia Artero
//Free to use
public class LightCarController : MonoBehaviour
{
     [SerializeField]
     private Light carLight;
     [SerializeField]
     private Transform sun;
     [SerializeField]
     private float sunRotation;

     void Awake()
     {
         carLight = GetComponent<Light>();
     }
     void Update()
     {
         sunRotation = sun.transform.localEulerAngles.x; //localEulerAngels to transform the nombers from randomness to something manageable

         if(sunRotation > 0 && sunRotation < 90) //0, 180   /50,330
         {
             carLight.enabled = false;   
         }
         else
         {
             carLight.enabled = true;
         }

         Debug.Log("Ángulo de rotación alrededor del eje X: " + sunRotation + " grados");
     }  

}
