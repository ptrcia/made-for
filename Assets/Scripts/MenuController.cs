using UnityEngine;
using UnityEngine.SceneManagement;

//Patricia Gracia Artero
//Free to use
public class MenuController : MonoBehaviour 
{

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene); 
    }

    public void Exit() 
    { 
        Application.Quit(); 
    } 
}
