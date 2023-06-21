using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnPillow : MonoBehaviour
{
    public bool isPlayerOnPillow = false;
    public GameObject RoomOriginal;
    public GameObject RoomSecond;
    public GameObject lamp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera") && lamp.activeSelf == false)
        {
            isPlayerOnPillow = true;
            Debug.Log("Player entered trigger!");
            RoomOriginal.SetActive(false);
            RoomSecond.SetActive(true);
        }
    }
}
