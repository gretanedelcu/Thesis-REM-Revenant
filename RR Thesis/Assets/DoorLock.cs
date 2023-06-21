using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorLock : MonoBehaviour
{
    public GameObject doorHandle1;
    public GameObject doorHandle2;
    public CloseDoor doorTrigger;
    AudioSource doorCloseSound;

    public GameObject doorClosed, handle1Closed, handle2Closed;

    public int type=1;
    public IsKeyUsed iskeyused;
    bool keyused = false;

    private void Start()
    {
        doorTrigger.GetComponent<CloseDoor>();
        doorCloseSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
       

        if (type == 1)
        {
            if (doorTrigger.playerPassed == true)
            {
                doorHandle1.SetActive(false);
                doorHandle2.SetActive(false);


                doorClosed.SetActive(true);
                doorCloseSound.Play();
                handle1Closed.SetActive(true);
                handle2Closed.SetActive(true);
                doorTrigger.playerPassed = false;
                this.gameObject.SetActive(false);
            }
        }
        if (type == 2)
        {
            keyused = iskeyused.GetComponent<IsKeyUsed>().keyused;
            if (keyused == true)
            {
                doorHandle1.SetActive(false);
                doorHandle2.SetActive(false);

                doorClosed.SetActive(true);
                handle1Closed.SetActive(true);
                handle2Closed.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
    }




    }

