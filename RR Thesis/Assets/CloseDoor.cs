using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public bool playerPassed = false;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerPassed = true;
           
        }
    }

}
