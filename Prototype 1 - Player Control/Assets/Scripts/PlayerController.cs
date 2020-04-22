﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        //Vehicle turn
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnSpeed);

    }
}
