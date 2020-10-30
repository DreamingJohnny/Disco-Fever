using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Trying to go to Level1");
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Debug.Log("TryingToQuitGame");

        Application.Quit();
    }



    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
