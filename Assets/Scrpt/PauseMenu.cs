using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Resume;
    public GameObject Mute;
    public GameObject UnMute;
    public GameObject MainMenu;
    public GameObject Pause;

    public GameObject PauseMenuUI;

    public AudioSource audioSource;

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PauseMenuUI.SetActive(false);
    }

    public void MuteGame()
    {
        audioSource.volume = 0;
        Mute.SetActive(false);
        UnMute.SetActive(true);
    }

    public void UnMuteGame()
    {
        audioSource.volume = 0.5f;
        Mute.SetActive(true);
        UnMute.SetActive(false);
    }

    public void MainMenuGame()
    {
        Time.timeScale = 1f;
        PauseMenuUI.SetActive(false);
        // Load the main menu scene
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        PauseMenuUI.SetActive(true);
    }
}
