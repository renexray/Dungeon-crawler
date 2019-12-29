using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerType : NetworkBehaviour
{
    void Start()
    {
        if (hasAuthority == false)
        {
            return;
        }
        

    }
    // Drag camera into here

    private Vector2 moveVelocity;
    private float movementSpeed = 5f;
    Vector2 bestGuessPosition;

    float ourLatency;
    float latencySmoothingFactor = 10;

    void Update()
    {

        if (hasAuthority == false)
        {

            bestGuessPosition = bestGuessPosition + (moveVelocity * Time.deltaTime);

            transform.position = Vector2.Lerp(transform.position, bestGuessPosition, Time.deltaTime * latencySmoothingFactor);

            return;
        }
        float x = Input.GetAxis("Horizontal") * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * Time.deltaTime;


        Vector3 tempVect = new Vector3(x, z, 0);
        tempVect = tempVect.normalized * movementSpeed * Time.deltaTime;

        this.transform.position += tempVect;


  

    }
}
