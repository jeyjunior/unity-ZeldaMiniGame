using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : PlayerBase
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            
        }
    }
}
