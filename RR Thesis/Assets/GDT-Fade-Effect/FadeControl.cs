using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeControl : MonoBehaviour
{

    public GameObject fadeEffect;
    public GameObject scriptPillow;
    public bool isPlayerReady;
    public GameObject blackFigureCutscene;
    public AudioSource monsterAudio;
    public GameObject lamp;

    // Start is called before the first frame update
    void Start()
    {
      //  monsterAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        isPlayerReady = scriptPillow.GetComponent<PlayerOnPillow>().isPlayerOnPillow;

        if (isPlayerReady == true && lamp.activeSelf==false)
        {
            fadeEffect.SetActive(true);
            blackFigureCutscene.SetActive(true);
         //   monsterAudio.PlayDelayed(8);
        }
    }
}
