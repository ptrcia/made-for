using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Manager:
//  -Reaload Level
//  -Controls volume
//  -Active/Disable pauseMenu
public class PauseManager : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    [SerializeField] Slider sliderMaster;
    [SerializeField] AudioMixer audioMixer;

    private void Start()
    {
        sliderMaster.value = PlayerPrefs.GetFloat("volumeMaster");
        Time.timeScale = 1; //important to remember unity to set it play
        AudioListener.pause = false; //important to say to unity to unpause music

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausePanel.activeInHierarchy)
            {
                pausePanel.SetActive(false);
                //Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                AudioListener.pause = false;

            }
            else
            {
                pausePanel.SetActive(true);
                //Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;
                AudioListener.pause = true;
            }
        }
    }
    public void volumeMaster(float volume)
    {
        audioMixer.SetFloat("volumeMaster", volume);
    }
    public void ReloadScene()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        AudioListener.pause = true;
        SceneManager.LoadScene(actualScene);
    }
}
