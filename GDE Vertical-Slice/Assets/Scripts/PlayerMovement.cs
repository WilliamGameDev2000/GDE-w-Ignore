﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController character;

    static Hertz hertz;

    public float speed = hertz.getLastVolume();

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
    }
}