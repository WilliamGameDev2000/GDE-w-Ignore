using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLose : MonoBehaviour
{
    public Collider Ball;
    public GameObject Sliders;
    public GameObject Cam1;
    public GameObject WinCam;
    public GameObject LoseCam;
    public GameObject CoinAppear;


    public Tilt PuzzleController;
    public Timer timer;

    public PickUpCoin coinCollected;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other == Ball)
        {
            Win();
        }
    }

    void Win()
    {
       
        Sliders.SetActive(false);
        Cam1.SetActive(false);
        WinCam.SetActive(true);
        LoseCam.SetActive(false);
        FindObjectOfType<AudioManager>().StopCoroutine("BallRolling");
        FindObjectOfType<AudioManager>().Play("Win");
        PuzzleController.rolling = false;
        if(coinCollected.collected == true)
        {
            CoinAppear.SetActive(true);
        }
        if(coinCollected.collected == false)
        {
            CoinAppear.SetActive(false);
        }
        
    }
 
}
