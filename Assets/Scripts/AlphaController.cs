using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Patricia Gracia Artero
//Free to use

public class AlphaController : MonoBehaviour
{
    Image image;

    private float inicialAlpha;
    private float inicialFadeTime;

    [SerializeField]
    float fade = 2.0f; // duration of the fading
    float finalAlpha;
    [SerializeField]
    float targetAlpha = 0;
    float progress;

    void Start()
    {
        image = GetComponent<Image>();
        inicialAlpha = image.color.a;
        //targetAlpha = new Color(colorInicial.r, colorInicial.g, colorInicial.b, 0);
        inicialFadeTime = Time.time;

    }
    private void Update()
    {
        //image.color.a = 0;
        //image.color -= new Color(0f, 0f, 0f, inicialAlpha);
        progress = (Time.time - inicialFadeTime) / fade;
        float actualAlpha = Mathf.Lerp(inicialAlpha, targetAlpha, progress);

        Color newColor = image.color;
        newColor.a = actualAlpha;

        image.color = newColor;
    }

}
