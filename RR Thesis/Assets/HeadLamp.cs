using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLamp : MonoBehaviour
{
    public GameObject headlighton;
    public GameObject head;
   
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            headlighton.SetActive(true);
            Destroy(head);
        }
    }
}
