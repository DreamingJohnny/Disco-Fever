using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        Debug.Log("TryingToQuitGame");

        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("JohanMenuScene");
    }
}
