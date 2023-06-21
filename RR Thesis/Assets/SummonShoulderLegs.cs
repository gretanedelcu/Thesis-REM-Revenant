using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonShoulderLegs : MonoBehaviour
{
    public GameObject pad1;
    public GameObject pad2;
    public GameObject pad3;
    public GameObject pad4;

    public GameObject redCorridorLight1;
    public GameObject redCorridorLight2;
    public GameObject monster;
    public GameObject redLights;
    AudioSource audiosolved;
    public bool testSolved=false;

    // Start is called before the first frame update
    void Start()
    {
       audiosolved = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if((pad1.GetComponent<Autohand.PlacePoint>().IsPlaced && pad2.GetComponent<Autohand.PlacePoint>().IsPlaced &&
            pad3.GetComponent<Autohand.PlacePoint>().IsPlaced && pad4.GetComponent<Autohand.PlacePoint>().IsPlaced) || testSolved==true)
        {
            redCorridorLight1.SetActive(true);
            redCorridorLight2.SetActive(true);
            monster.SetActive(true);
            redLights.SetActive(true);
            audiosolved.enabled = true;
        }
    }
}
