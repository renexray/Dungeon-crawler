using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror;
public class loadLevel : NetworkBehaviour
{
    public Health life;
    public InventoryObject inventory;
    public levelcount level;
    //public levelcount data;

    void OnTriggerEnter2D(Collider2D other){
    if(other.CompareTag("Ladder"))
        {
            levelcount.scorevalue += 1;
            life.SaveFile();
            inventory.Save();
            level.datasave();
            //SceneManager.LoadScene("Game"); //Load scene called Game
            //Time.timeScale = 0.000001f;
            transform.position = Vector3.zero;

        }
    }
    public void myload()
    {
        levelcount.scorevalue += 1;
        life.SaveFile();
        inventory.Save();
        level.datasave();
    }
}
