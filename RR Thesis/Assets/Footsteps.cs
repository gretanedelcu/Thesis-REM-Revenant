using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepsSound;

    private Vector3 previousPosition;
    private float movementThreshold = 0.1f; // Adjust this threshold according to your needs

    private void Start()
    {
        // Initialize the previous position with the initial position of the GameObject
        previousPosition = transform.position;
        footstepsSound = GetComponent<AudioSource>();
    }

    void Update()
    {

        // Calculate the distance between the current position and the previous position
        float distance = Vector3.Distance(transform.position, previousPosition);

        // Check if the distance exceeds the movement threshold
        if (distance > movementThreshold)
        {
            // The GameObject is moving
            footstepsSound.enabled = true;
            Debug.Log("walkin");
        }
        else
        {
            // The GameObject is not moving
            footstepsSound.enabled = false;
        }

        // Update the previous position with the current position for the next frame
        previousPosition = transform.position;


    }
}
