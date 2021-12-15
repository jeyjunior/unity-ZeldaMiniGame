using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : PlayerBase
{
    //PlayerMovementControl
    public float speed = 2;
    Rigidbody rb;
    public float rotationSpeed = 1000;

    //Actions
    public bool carryngObjects;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        PlayerMovement();
    }


    public Vector3 PlayerMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 pos = new Vector3(x, 0, z);
        rb.MovePosition(transform.position + pos * Time.deltaTime * speed);

        //Rotação do player será travada caso esteja carrengado algum objeto
        if (!carryngObjects)
        {
            if (pos != Vector3.zero /* Vector3(0, 0, 0) */)
            {
                //from = estado atual
                //to = tecla que esta sendo pressionada (W,A,S,D) indica a direção da rotação
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(pos), rotationSpeed * Time.deltaTime);
            }
        }

        return pos;
    }

    void PlayerJump()
    {
        //Sistema de pulo
    }

}
