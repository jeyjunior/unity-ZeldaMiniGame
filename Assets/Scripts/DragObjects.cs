using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
    Rigidbody rb;
    PlayerMove player;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (player.carryngObjects)
            {
                Vector3 pMovement = player.PlayerMovement();
                float speed = player.speed;
                rb.mass = 100;

                rb.MovePosition(transform.position + pMovement * Time.deltaTime * speed);

            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.mass = 1000;
        }
    }


}
