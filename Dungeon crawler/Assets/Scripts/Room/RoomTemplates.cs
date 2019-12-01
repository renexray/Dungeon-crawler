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
    
    //public GameObject Dungeon;

    /*void Start(){
        Invoke("Savenew", 5f);
    }
    void Savenew(){
        GameObject duplicate = Instantiate(Dungeon);
        Dungeon.SetActive(false);
    }*/
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
    [System.Serializable]
     class PaR 
     {        
         public float OPX;
         public float OPY;
         public float OPZ;
     }
    public void SaveFile3()
    {
        SaveToFile.SaveFile3(this);
    }
    public void LoadFile3()
    {
        Saving data = SaveToFile.LoadFile3();
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
     public void Save(){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/room.oof";
        FileStream stream = new FileStream(path, FileMode.Create);

      List<PaR> newDataCollection = new List<PaR>();
      for (int i = 0; i < rooms.Count; i++)
      {
          PaR newData = new PaR();
          newData.OPX = rooms[i].transform.position.x;
          newData.OPY = rooms[i].transform.position.y;
          newData.OPZ = rooms[i].transform.position.z;
          newDataCollection.Add(newData);
      }
      formatter.Serialize(stream, newDataCollection);
      stream.Close();
  }
     public void Load()
     {
         string path = Application.persistentDataPath + "/room.oof";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            //Saving data = formatter.Deserialize(stream) as Saving;
            List<PaR> newDataCollection1 = (List<PaR>)formatter.Deserialize (stream);
             ;
             for (int i = 0; i < rooms.Count; i++) {
                 rooms [i].transform.position = new Vector3 (newDataCollection1 [i].OPX, newDataCollection1 [i].OPY, newDataCollection1 [i].OPZ);
                 if(i == rooms.Count-2)
                {
                    //DestroyImmediate (Monster, true);
                    GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
   foreach(GameObject enemy in enemies)
   GameObject.Destroy(enemy);
                    Instantiate(Monster, rooms[i].transform.position, Quaternion.identity);
                }
                
                if(i == rooms.Count-1)
                {
                    //Destroy (Boss, true);
                    Instantiate(Boss, rooms[i].transform.position, Quaternion.identity);
                }
             }
            stream.Close();
            //return newDataCollection;

        }else
        {
            Debug.LogError("Save file not found in " + path);
            //return null;
        }
    /*
         BinaryFormatter bf = new BinaryFormatter();
         using (FileStream file = new FileStream(FileName, FileMode.Create));
         {
             List<PaR> newDataCollection = (List<PaR>)>bf.Deserialize(file);
             for(int i = 0; i < roomss.Length; i++)        
             {
                 roomss[i].transform.position = new Vector3(newDataCollection[i].OPX, newDataCollection[i].OPY, newDataCollection[i].OPZ);
             }
         }
         */
     }
}
