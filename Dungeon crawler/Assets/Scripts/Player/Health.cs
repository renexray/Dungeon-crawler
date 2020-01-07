using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Health : NetworkBehaviour
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
            RpcRespaw();
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

    [Client]
    void RpcRespaw() {
        if (!base.hasAuthority)
        {
            transform.position = Vector3.zero;
        }
    }
}
