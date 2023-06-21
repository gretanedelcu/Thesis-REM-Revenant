using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    Animator controller1;
    Animator controller3;
    public GameObject monster1,monster3;
    public GameObject mesh1, mesh2, mesh3;
    public MonsterApproached triggerMonster;
    public AudioSource soundattack;
    public AudioSource soundrunning;

    // Start is called before the first frame update
    void Start()
    {
        controller1 = monster1.GetComponent<Animator>();
        controller3 = controller3.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
       
        if (triggerMonster.GetComponent<MonsterApproached>().playerapproached == true)
        {
            mesh2.gameObject.SetActive(false);
            mesh3.gameObject.SetActive(true);
            controller1.Play("Base Layer.ShoulderAttack");
            soundattack.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            controller1.enabled = true;
            controller1.Play("Base Layer.ShoulderApproach");
            soundrunning.enabled = true;
            Invoke("ActionAfterDelay", 5.2f);
            var squeak = GetComponent<AudioSource>();
            squeak.enabled = true;
        }

      
    }
    private void ActionAfterDelay()
    {
        // Code to execute after the delay
        mesh1.gameObject.SetActive(false);
        mesh2.gameObject.SetActive(true);
    }
}
