using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    

    private CharacterController controller;
    private float moveSpeed = 10f;
    private bool groundedPlayer;
    private float gravityValue = 30f;
    private Vector3 playerVelocity;
    private Camera cam;

   
    

    // Start is called before the first frame update
    void Start()
    {
        //controller = gameObject.AddComponent<CharacterController>();
        Physics.gravity = new Vector3(0, -gravityValue, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Vector3 lookdir = mousePos - rb.position;
        Movement();
    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.W)) //move forward
        {
            transform.Translate(0f, 0f, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) //move back
        {
            transform.Translate(0f, 0f, -moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) //move left
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D)) //move right
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0f, 0f);
        }
        
        
        /*groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * moveSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetKey(KeyCode.Space) && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);*/
    }
}
