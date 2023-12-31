using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offsetThirdPerson = new Vector3(1f, 5, -7);
    private Vector3 offsetFirstPerson = new Vector3(1f, 2.3f, 1.1f);
    private bool isFirstPerson = false;
    // Start is called before the first frame update
    void Start()
    {
         // Set initial position (third person)
        transform.position = player.transform.position + offsetThirdPerson;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Toggle between first person and third person
            isFirstPerson = !isFirstPerson;

            if (isFirstPerson)
            {
                // Switch to first person
                transform.localPosition = offsetFirstPerson;
            }
            else
            {
                // Switch to third person
                transform.localPosition = offsetThirdPerson;
            }
        }

        // Always follow the player in both modes
        transform.position = player.transform.position + (isFirstPerson ? offsetFirstPerson : offsetThirdPerson);
        
    }
}
