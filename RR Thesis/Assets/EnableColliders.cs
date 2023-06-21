using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableColliders : MonoBehaviour
{
    public GameObject trigger;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger.SetActive(true);
        }
    }
}
