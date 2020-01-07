using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject mainmenus;
    public GameObject cradits;
    public GameObject settings;
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
     public void mainmenu()
    {
        SceneManager.LoadScene("Main");
    }

    public void Credits()
    {
        mainmenus.SetActive(false);
        cradits.SetActive(true);
    }
    public void CreditsBack()
    {
        mainmenus.SetActive(true);
        cradits.SetActive(false);
    }
    public void Settings()
    {
        mainmenus.SetActive(false);
        settings.SetActive(true);
    }
    public void SettingsBack()
    {
        mainmenus.SetActive(true);
        settings.SetActive(false);
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
