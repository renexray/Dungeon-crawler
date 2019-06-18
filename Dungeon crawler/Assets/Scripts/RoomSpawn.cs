using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawn : MonoBehaviour
{
    public int openingDirection;
    //1 - ^
    //2 - p
    //3 - v
    //4 - q

    private RoomTemplates templates;
    private int rand;
    private bool spawned = false;

    private float waitTime = 4f;

    void Start(){
        Destroy(gameObject, waitTime);
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
    }

    void Spawn(){
    
    if (spawned == false){

    if(openingDirection == 1){
        rand = Random.Range(0, templates.vRooms.Length);
        Instantiate(templates.vRooms[rand], transform.position, templates.vRooms[rand].transform.rotation);
    }
    else if(openingDirection == 2){
        rand = Random.Range(0, templates.qRooms.Length);
         Instantiate(templates.qRooms[rand], transform.position, templates.qRooms[rand].transform.rotation);
    }
    else if(openingDirection == 3){
        rand = Random.Range(0, templates.ARooms.Length);
        Instantiate(templates.ARooms[rand], transform.position, templates.ARooms[rand].transform.rotation);
    }
    else if(openingDirection == 4){
        rand = Random.Range(0, templates.pRooms.Length);
        Instantiate(templates.pRooms[rand], transform.position, templates.pRooms[rand].transform.rotation);
    }
    spawned = true;
    }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Spawnshop")){
             spawned = true;
        }
        else if(other.CompareTag("Spawnpoint"))
        {
            if(other.GetComponent<RoomSpawn>().spawned == false && spawned == false){
                Instantiate(templates.cRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            spawned = true;
        }
    }
  }
