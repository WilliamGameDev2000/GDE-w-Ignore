using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;

    public string gameScene;

    public void Awake()
    {
        startButton.onClick.AddListener(playGame);
        exitButton.onClick.AddListener(exitGame);
    }

    public void playGame()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void exitGame()
    {
        // doesn't work in editor
        Application.Quit();
        Debug.Log("EXIT");
    }
}
