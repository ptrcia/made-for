using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    public Slider sliderMaster;
    public AudioMixer audioMixer;

    private void Start()
    {
        sliderMaster.value = PlayerPrefs.GetFloat("volumeMaster");

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
}
