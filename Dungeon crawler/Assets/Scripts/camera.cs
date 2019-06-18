using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject LookAt;
    public Vector3 offset = new Vector3(0,0,0);

    /* public float boundryX =2.0f;
    public float boundryY =2.0f;
    private Vector3 Vector_ZERO = Vector2.zero;
    private Vector3 dpos;
    *//*
      void FixedUpdate(){
          
        if (LookAt){
            transform.position = new Vector3(
                LookAt.transform.position.x + offset.x,
                LookAt.transform.position.y + offset.y,
                LookAt.transform.position.z + offset.z
            );
        }
      }*/
    void FixedUpdate(){
        Vector3 viewPosition = GetComponent<Camera>(). WorldToViewportPoint(LookAt.transform.position);
        if (viewPosition.x > 0.9f){
            transform.position = new Vector3(
                transform.position.x + 10,
                transform.position.y + offset.y,
                transform.position.z + offset.z
            );
        }
        else if (viewPosition.x < 0.1f){
            transform.position = new Vector3(
                transform.position.x + -10,
                transform.position.y + offset.y,
                transform.position.z + offset.z
            );
        }
        if (viewPosition.y > 1f){
            transform.position = new Vector3(
                transform.position.x + offset.x,
                transform.position.y + 10,
                transform.position.z + offset.z
            );
        }
        else if (viewPosition.y < 0f){
            transform.position = new Vector3(
                transform.position.x + offset.x,
                transform.position.y - 10,
                transform.position.z + offset.z
            );
        }
    }
}
