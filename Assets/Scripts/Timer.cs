using UnityEngine;
using UnityEngine.SceneManagement;

//Patricia Gracia Artero
//Free to use
public class Timer : MonoBehaviour
{
    float timer;        
    float maxTime = 60f; //set seconds

    void Start()
    {
        timer = maxTime; //Time is being counted down
    }
    void Update()
    {
        for (int i = 0; i < timer; i--)
        {
            //show everytime time is counted down???????????????
        }

        //Timer();
    }

    /*void Timer()
    {
        if (timer < 0)
        {
            MenuController.
        }
        if (timer < 6)
        {
            //Play countdown audio
        }*/
    }
