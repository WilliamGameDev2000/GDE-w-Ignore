using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button startButton;
    public Button instructionsButton;
    public Button optionsButton;
    public Button pauseButton;

    public string gameScene;
    public string instructionsScene;
    public string optionsScene;
    public string pauseScene;

    public void Awake()
    {
        startButton.onClick.AddListener(Play);
        instructionsButton.onClick.AddListener(Instructions);
        optionsButton.onClick.AddListener(Options);
        pauseButton.onClick.AddListener(Pause);
    }

    public void Play()
    {
        SceneManager.LoadScene(gameScene);
        FindObjectOfType<AudioManager>().Play("Button");
    }

    public void Instructions()
    {
        SceneManager.LoadScene(instructionsScene);
        FindObjectOfType<AudioManager>().Play("Button");
    }

    public void Options()
    {
        SceneManager.LoadScene(optionsScene);
        FindObjectOfType<AudioManager>().Play("Button");
    }

    public void Pause()
    {
        SceneManager.LoadScene(pauseScene);
        FindObjectOfType<AudioManager>().Play("Button");
    }

    //public void exitGame()
    //{
    //    // doesn't work in editor
    //    Application.Quit();
    //    Debug.Log("EXIT");
    //}
}
