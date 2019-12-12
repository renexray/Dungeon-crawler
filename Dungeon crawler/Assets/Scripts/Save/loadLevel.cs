using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadLevel : MonoBehaviour
{
    public Health life;
    public InventoryObject inventory;
    public levelcount level;
    void OnTriggerEnter2D(Collider2D other){
    if(other.CompareTag("Ladder"))
        {
            levelcount.scorevalue += 1;
            life.SaveFile();
            inventory.Save();
            level.SaveFile3();
            SceneManager.LoadScene("Game"); //Load scene called Game
        }
    }
}
