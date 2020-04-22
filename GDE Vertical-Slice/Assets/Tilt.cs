using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    public GameObject board;

    public float angleH;
    public float angleV;

    public bool rolling = true;

    private void Start()
    {
        //Theme Sound Start on level start
        FindObjectOfType<AudioManager>().Play("PuzzleTheme");
    }

    void Update()
    {
        board.transform.localRotation = Quaternion.Euler(-angleH, 0.0f, angleV);
        
    }

    public void changeHorizontalAngle(float newAngle)
    {
        angleH = newAngle;
        //Ball Rolling sound added
        if (angleH > 0.5f)
        {
            if (rolling)
            {
                FindObjectOfType<AudioManager>().Play("BallRolling");
            }
        }
        else if (angleV < 0)
        {
            if (rolling)
            {
                FindObjectOfType<AudioManager>().Play("BallRolling");
            }
        }

    }

    public void changeVerticalAngle(float newAngle)
    {
        angleV = newAngle;
        //Ball Rolling sound added
        if (angleV > 0.3f)
        {
            if (rolling)
            {
                FindObjectOfType<AudioManager>().Play("BallRolling");
            }
        }
        else if (angleV < 0)
        {
            if (rolling)
            {
                FindObjectOfType<AudioManager>().Play("BallRolling");
            }
        }
        

    }
}
