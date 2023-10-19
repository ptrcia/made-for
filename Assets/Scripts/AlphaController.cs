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
    [SerializeField]
    float targetAlpha = 0;
    float progress;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    void Start()
    {
        inicialAlpha = image.color.a; //a = alpha
        inicialFadeTime = Time.time;

    }

    private void Update()
    {
        //image.color.a = 0;
        //image.color -= new Color(0f, 0f, 0f, inicialAlpha);
        progress = (Time.time - inicialFadeTime) / fade;
                          //from inicial alpha -> the alpha i want ->the velocity of the fading
        float actualAlpha = Mathf.Lerp(inicialAlpha, targetAlpha, progress);

        Color newColor = image.color;
        newColor.a = actualAlpha;

        image.color = newColor;
    }

}
