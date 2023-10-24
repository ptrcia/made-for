using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The "OnLevelWasLoaded" method seemed to work for what I wanted,
//but I just found out that Unity already has an alternative that works the same but doesn't give you that warning message and doesn't mess with the PC memory.
//It is more complex, it is necessary to add an OnEnabled and an OnDisable that are attentive to what OnLevelLoading does.
//+INFO
//https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager-sceneLoaded.html
public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //Method from Unity that prevents something to be deleted when the scene is changed
    }
    public void DestroyNow()
    {
        Destroy(this.gameObject);
    }

    /*private void OnLevelWasLoaded(int level)
    {
        //print("Comprobando nivel");
        if (level == 5)
        {
            //print("Ultimo nivel");
            DestroyNow();
        }
    }*/
    void OnEnable()
    {
        //Tell our 'OnLevelFinishedLoading' function to start listening for a scene change as soon as this script is enabled.
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        //Tell our 'OnLevelFinishedLoading' function to stop listening for a scene change as soon as this script is disabled. Remember to always have an unsubscription for every delegate you subscribe to!
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        //print("Comprobando nivel");
        if (scene.buildIndex == 5)
        {
            //print("Ultimo nivel");
            DestroyNow();

            //Debug.Log("Level Loaded");
            //Debug.Log(scene.name);
            //Debug.Log(mode);
        }
    }
}
