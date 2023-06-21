using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsKeyUsed : MonoBehaviour
{
    public bool keyused = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            keyused = true;
        }
    }
}
