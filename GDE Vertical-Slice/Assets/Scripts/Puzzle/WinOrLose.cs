using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLose : MonoBehaviour
{
    public Collider Ball;
    public GameObject Sliders;
    public GameObject Cam1;
    public GameObject Cam2;

    public Tilt PuzzleController;


    private void OnTriggerEnter(Collider other)
    {
        if (other == Ball)
        {
            Sliders.SetActive(false);
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            FindObjectOfType<AudioManager>().StopCoroutine("BallRolling");
            FindObjectOfType<AudioManager>().Play("Win");
            PuzzleController.rolling = false;


        }
    }
}
