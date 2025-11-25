using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneHard : MonoBehaviour
{
    
    public void RestartButton()
    {
        SceneManager.LoadScene(3);
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
   
}
