using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{

    public Transform player;
    public float rotationLimit = 11;
    float mouseX;
    float mouseY;


    void FixedUpdate()
    {
        transform.position = player.transform.position;

    }

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            mouseX += rotationLimit * Input.GetAxis("Mouse X");
            mouseY -= rotationLimit * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
        }
    }


}

