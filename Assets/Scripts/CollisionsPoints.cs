using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
//Patricia Gracia Artero
//Free to use
public class Collisions : MonoBehaviour
{
    //This script is attached to the objects to be thrown to the ground.
    //When your collider collides with the collider on the ground,
    //a point is added to the score and a small sound is played.
   
    public GameObject numberText; //text
    public GameObject audioCorrect;   //?????????
    public AudioClip correctAudio; //?????????????????
    int numberPoints;
    public int scene;
    public int maxPoints; //total number oof objests in scene

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (numberPoints == maxPoints)
        {
            NextLevel();
        }
    }

    private void Awake()
    {
        correctAudio = GetComponent<AudioClip>();
        //numberText = GetComponent<Text>();
    }
    //POINTS
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            //Add 1 point
            AddPoint();
            audioCorrect.SetActive(true);
            //Play audio
          //  CorrectAudio.Play();???? it does not work??????????
        }
    }
    //NEXT LEVEL
    //If each of the objects has fallen down, in addition to the points and music,
    //you will pass to the next level.
    void NextLevel()
    {
     //   MenuController.LoadScene(scene);//connect this  script with other ????????????
    }

    void AddPoint()
    {
        numberPoints = +1;
    }
}
    //void RemovePoint(){ } I dont know if I am goint to need it
 
