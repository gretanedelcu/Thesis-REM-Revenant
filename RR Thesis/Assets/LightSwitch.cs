using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Autohand;

public class LightSwitch : MonoBehaviour
{
    public GameObject lightRoom;
    public GameObject lightRoom2;
    public GameObject lamp1;
    public GameObject lamp2;
    public GameObject switchOff;
    public GameObject switchOn;
    public PhysicsGadgetHingeAngleReader sliderReader;

    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        lightRoom.SetActive(false);
        lightRoom2.SetActive(false);
        lamp1.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        lamp2.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

    // Update is called once per frame
    void Update()
    {
        if(sliderReader.GetValue() == 1)
        {
            lightRoom.SetActive(true);
            lightRoom2.SetActive(true);
            lamp1.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            lamp2.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            audioData.Play();
        }
        if (sliderReader.GetValue() == -1)
        {
            lightRoom.SetActive(false);
            lightRoom2.SetActive(false);
            lamp1.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            lamp2.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            audioData.Play();
        }
    }
}

