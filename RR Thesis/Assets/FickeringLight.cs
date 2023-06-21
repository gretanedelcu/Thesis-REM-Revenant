using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FickeringLight : MonoBehaviour
{
    Light tvlight;
    public float minWaitTime;
    public float maxWaitTime;

    // Start is called before the first frame update
    void Start()
    {
        tvlight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime,maxWaitTime));
            tvlight.intensity = Mathf.PingPong(Time.time, 0.2f) + 0.25f;
          //  tvlight.intensity = Mathf.PingPong(Time.time, 0.5f);
          //  tvlight.intensity = Mathf.PingPong(Time.time, 0.2f);
          //  tvlight.intensity = Mathf.PingPong(Time.time, 0.3f);
        }
    }
}
