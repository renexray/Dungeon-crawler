using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
     
    public static bool GamePause = false;
    public GameObject PauseMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("escape"))     
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
    void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }
    void Stop()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0.000001f;
        GamePause = true;
    }
}
