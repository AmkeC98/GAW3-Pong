using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void ShowInstructions()
    {
        Debug.Log("SHOW INSTRUCTIONS");
        SceneManager.LoadScene("InstructionsScene");
    }

    public void StartGame()
    {
        Debug.Log("START GAME");
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }
}
