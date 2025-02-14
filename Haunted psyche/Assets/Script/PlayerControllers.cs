using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllers : MonoBehaviour
{
    #region variables
    float horizontal;
    float vertical;
    bool isRunning;
    bool isGrounded;
    [SerializeField] LayerMask ground;
    
    #endregion

    #region scripts
    CameraController controller;
    Move move;
    JumpScript jumpScript;
    PickObject pickObject;
    Flashlight flashlight;
    Pause pause;
    #endregion
    void Start()
    {
        isRunning = false;
        isGrounded= true;
        //Actions Scripts
        controller = GetComponent<CameraController>();
        move       = GetComponent<Move>();
        jumpScript = GetComponent<JumpScript>();
        pickObject = GetComponent<PickObject>();
        flashlight = GetComponent<Flashlight>();
    }
    private void Update()
    {
        controller.Look();
        isGrounded = Physics.Raycast(transform.position,Vector3.down,2.5f*0.5f +0.2f, ground);
    
        //Flashlight
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            flashlight.Toggle();
        }
        //Jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
           
            jumpScript.Jump();
        }
        //Interact
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            pickObject.Grab();
        }
    }

    void FixedUpdate()
    {
        //Movement input
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        isRunning = Input.GetKey(KeyCode.LeftShift) && vertical ==1;
        move.Mover(horizontal,vertical,isRunning);
        
    }
}
