using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFall : MonoBehaviour
{
    public GameObject player;
    public GameObject respawnpoint;
    public bool playerfalls = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = respawnpoint.transform.position;
            playerfalls = true;
        }
    }
}
