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
    public bool boatMooving = false;


    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement = new Vector3(1.0f, 0.0f, 0.0f);
        //movement *= speed;

        transform.Translate(transform.right * speed * Time.deltaTime, Space.World);
        
        //character.Move(movement * Time.deltaTime);
        character.transform.Rotate(0, angle, 0);

        if (speed == 0)
        {
            boatMooving = false;
            Debug.Log("not mooving");
        }
        if (speed > 0)
        {
            boatMooving = true;
            Debug.Log("mooving");
        }
        if (boatMooving)
        {
            FindObjectOfType<AudioManager>().Play("BoatStill");
        }
        if (!boatMooving)
        {
            FindObjectOfType<AudioManager>().Play("BoatMoving");
            
        }


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
