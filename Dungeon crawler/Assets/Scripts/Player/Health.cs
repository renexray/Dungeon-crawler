using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    Image life;
    float maxHealth=100f;
    public static float healthlife;
    void Start()
    {
        life =GetComponent<Image>();
        healthlife = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        life.fillAmount = healthlife / maxHealth;
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
