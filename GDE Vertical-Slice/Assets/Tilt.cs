using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    public GameObject board;

    public float angleH;
    public float angleV;

    void Update()
    {
        board.transform.localRotation = Quaternion.Euler(-angleH, 0.0f, angleV);
    }

    public void changeHorizontalAngle(float newAngle)
    {
        angleH = newAngle;
    }

    public void changeVerticalAngle(float newAngle)
    {
        angleV = newAngle;
    }
}
