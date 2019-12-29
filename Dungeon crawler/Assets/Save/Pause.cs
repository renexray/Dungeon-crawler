using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
     
    public static bool GamePause = false;
    public GameObject PauseMenu;
    //public GameObject MainMenu;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("e"))     
        {   
            if(GamePause == true)
            {
                Resume();
            } else
            {
                Stop();
            }
        }   
    } 
    public void Resume()
    {
        PauseMenu.SetActive(false);
        GamePause = false;
    }
    public void Stop()
    {
        PauseMenu.SetActive(true);
        GamePause = true;
    }
    /*public void gameStart()
    {
        MainMenu.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }*/

}
