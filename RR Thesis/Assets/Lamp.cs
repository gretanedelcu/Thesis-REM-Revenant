using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    private Vector3 initialPosition;
    public Rigidbody pullstring;
    public GameObject collisionOnOff;
    public Light lightLamp;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void StringReleased()
    {
        pullstring.MovePosition(initialPosition);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Onofftrigger")
        {
            lightLamp.gameObject.SetActive(false);
            gameObject.GetComponentInParent<Renderer>().material.DisableKeyword("_EMISSION");
           
        }
    }
}
