using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dpoint : MonoBehaviour
{
  public float timeLeft = 20f;
  void OnTriggerEnter2D(Collider2D other){
      
    Destroy(other.gameObject);
    destroyTimer ();
    }
    void destroyTimer(){
        //coroutine calls the destroyer function, its a function that runs independently.
        StartCoroutine ("destroyer");
  }
  IEnumerator destroyer(){
        //wait for the timeLeft in seconds.
        yield return new WaitForSeconds (timeLeft);

        //Then destroy the object this script is attached to
        Destroy (gameObject);
}
}
