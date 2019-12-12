using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
 


public class RoomTemplates : MonoBehaviour
{
    public GameObject[] ARooms;
    public GameObject[] pRooms;
    public GameObject[] vRooms;
    public GameObject[] qRooms;

    public GameObject cRoom;

    public List<GameObject> rooms;
    public Transform[] roomss;

    public float waitTime;
    private bool spawnedBoss;
    public GameObject Boss;
    public GameObject Monster;
    
    void Update()
    {
        if (waitTime <=0 && spawnedBoss == false)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if(i == rooms.Count-2)
                {
                    Instantiate(Monster, rooms[i].transform.position, Quaternion.identity);
                }
                if(i == rooms.Count-1)
                {
                    Instantiate(Boss, rooms[i].transform.position, Quaternion.identity);
                    spawnedBoss = true;
                }
            }

        }
        else
        {
            waitTime-=Time.deltaTime;
        }
    }
}
