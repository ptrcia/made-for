using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

//Patricia Gracia Artero
//Free to use
public class MenuController : MonoBehaviour 
{
    public UnityEvent continueNextScene;
    public GameObject continueScene;
    int nextScene;
    Scene sceneLoaded;
    private void Start()
    {
        sceneLoaded = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (Input.GetKeyDown("escape")) //Exit the application using ESC
        {
            Exit();
        }

        if (continueScene.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
            }
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
