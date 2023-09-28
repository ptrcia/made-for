using UnityEngine;
using UnityEngine.SceneManagement;

//Patricia Gracia Artero
//Free to use
public class MenuController : MonoBehaviour 
{
    void Update()
    {
        if (Input.GetKeyDown("escape")) //Exit the application using ESC
        {
            Exit();
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


}
