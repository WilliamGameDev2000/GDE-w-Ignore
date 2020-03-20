using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController character;

    static Hertz hertz;

    public float speed = hertz.getLastVolume();

    public float angle;

    public Vector3 movement;


    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(1.0f, 0.0f, 1.0f);
        movement *= speed;

        
        character.Move(movement * Time.deltaTime);
        character.transform.Rotate(0, angle, 0);
        
    }

    public void AdjustSlider(float newSpeed)
    {
        speed = 20 * newSpeed;
    }

    public void changeAngle(float newAngle)
    {
        angle = newAngle;
    }
}
