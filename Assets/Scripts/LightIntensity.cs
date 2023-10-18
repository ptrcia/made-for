using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Patricia Gracia Artero
//Free to use
public class LightIntensity : MonoBehaviour
{
    Light lightObject;

    private float inicialIntensity;
    private float inicialFadeTime;

    [SerializeField]
    float fade = 2.0f; // duration of the fading
    [SerializeField]
    float targetIntensity;
    float progress;

    void Start()
    {
        lightObject = GetComponent<Light>();
        inicialIntensity = lightObject.intensity;
        inicialFadeTime = Time.time;
    }

    void Update()
    {
        progress = (Time.time - inicialFadeTime) / fade;
        lightObject.intensity = Mathf.Lerp(inicialIntensity, targetIntensity, progress); //lerp to constant increasing
    }
}
