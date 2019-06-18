using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadLevel : MonoBehaviour
{
 
void OnTriggerEnter2D(Collider2D other){
    if(other.CompareTag("Ladder")){
        SceneManager.LoadScene("Game"); //Load scene called Game
        }
    }
public void SaveFile2()
    {
        SaveToFile.SaveFile2(this);
    }
public void LoadFile2()
    {
        Saving data = SaveToFile.LoadFile2();
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
}
