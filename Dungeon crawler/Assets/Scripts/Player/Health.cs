using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    Image life;
    float maxHealth=100f;
    public static float healthlife;
    public GameObject GameOver;
    void Start()
    {
        life =GetComponent<Image>();
        healthlife = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        life.fillAmount = healthlife / maxHealth;
        if (healthlife <= 0f) 
        {
            GameOver.SetActive(true);
            Time.timeScale = 0.000001f;
        }
    }
    public void SaveFile()
    {
        SaveToFile.SaveFile(this);
    }
    public void LoadFile()
    {
        Saving data = SaveToFile.LoadFile();
        healthlife = data.healthlife;
    }
}
