using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseSound : MonoBehaviour
{
    public Collider Ball;
    public GameObject Sliders;
    public GameObject Cam1;
    public GameObject LoseCam;
    public GameObject WinCam;

    public Tilt PuzzleController;
    public Timer timer;
   

    private void OnTriggerStay(Collider other)
    {
        if (other == Ball && timer.time < 0)
        {
            
            Lose();
        }
    }
    
    void Lose()
    {
        
        Sliders.SetActive(false);
        Cam1.SetActive(false);
        LoseCam.SetActive(true);
        WinCam.SetActive(false);
        PuzzleController.rolling = false;
        SceneManager.LoadScene(0);

    }
}
