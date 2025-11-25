using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneMedium : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene(2);
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
