using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            if (Input.GetMouseButton(0))
            {
                Carryng(true);
            }

            if (Input.GetMouseButtonUp(0))
            {
                Carryng(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            Carryng(false);
        }
    }

    void Carryng(bool value)
    {
        GetComponent<PlayerMove>().carryngObjects = value;
    }
}
