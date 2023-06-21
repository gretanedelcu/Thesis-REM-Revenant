using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRadio : MonoBehaviour
{
    AudioSource radioGibberish;
    public AudioClip buttonON, buttonOFF;
    bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        radioGibberish = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void  PressOn()
    {
        if (isOn == false)
        {
            radioGibberish.Play();
            radioGibberish.PlayOneShot(buttonON);
            isOn = true;
        }
        else
        {
            isOn = false;
            radioGibberish.PlayOneShot(buttonOFF);
            radioGibberish.Stop();
        }
    }

  
}
