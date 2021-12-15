using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : PlayerBase
{
    //PlayerMovementControl
    public float speed = 2;
    Rigidbody rb;
    private float rotationSpeed = 700;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        PlayerMovement();
    }


    void PlayerMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 pos = new Vector3(x, 0, z);
        rb.MovePosition(transform.position + pos * Time.deltaTime * speed);

        if(pos != Vector3.zero /* Vector3(0, 0, 0) */)
        {
            //RotateTowards(from, to, rotationSpeed)
            //from = estado atual
            //to = tecla que esta sendo pressionada (W,A,S,D) indica a direção da rotação
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(pos), rotationSpeed * Time.deltaTime);
        }

        
    }

    void PlayerJump()
    {
        //Sistema de pulo
    }

}
