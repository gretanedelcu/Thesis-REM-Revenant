using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterApproached : MonoBehaviour
{
    public bool playerapproached = false;
    public AudioSource attacksound;
    public GameObject player;
    public GameObject respawnpoint;

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
        playerapproached = true;
        attacksound.enabled=true;
        Invoke("Delayedrelocate", 1.5f);

    }

    private void Delayedrelocate()
    {
        player.transform.position = respawnpoint.transform.position;
    }
}
