using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class MenuController : MonoBehaviour 
{
    //Manage the scenes
    Scene sceneLoaded;
    private void Start()
    {
        sceneLoaded = SceneManager.GetActiveScene();
    }
    void Update()
    {
        //I know this is outrageous, but it works :)
        //Is a shortcut for me to work easier
        if (Input.GetKey("0"))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey("1"))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKey("2"))
        {
            SceneManager.LoadScene(2);
        }
        if (Input.GetKey("3"))
        {
            SceneManager.LoadScene(3);
        }
        if (Input.GetKey("4"))
        {
            SceneManager.LoadScene(4);
        }
        if (Input.GetKey("5"))
        {
            SceneManager.LoadScene(5);
        }
        if (Input.GetKey("6"))
        {
            SceneManager.LoadScene(6);
        }

    }
    public void LoadScene(int scene) //Choose Scene in Unity Editor
    {
        SceneManager.LoadScene(scene); 
    }

    public void Exit() //Exit the application. For the buttons.
    { 
        Application.Quit(); 
    }
    public void URL() //Unity Method to include URL to click on
    {
        Application.OpenURL("https://ptrcia.github.io/porfolio/");
    }
}
