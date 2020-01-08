using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Health : NetworkBehaviour
{
    public const int maxHealth = 300;
    [SyncVar (hook = "OnTakedamage")] public int currenthealth = maxHealth;
    //public static float healthlife;
    public RectTransform healthbar;
    public void Takedamage(int amount)
    {
        if (!isServer)
        {
            return;
        }

        currenthealth -= amount;
        if (currenthealth <= 0)
        {
            currenthealth = maxHealth;
            RpcRespawn();

        }
        healthbar.sizeDelta = new Vector2(currenthealth/2, healthbar.sizeDelta.y);
    }

    void OnTakedamage(int health)
    {
        healthbar.sizeDelta = new Vector2(health/2, healthbar.sizeDelta.y);
    }
    [Client]
    void RpcRespawn()
    {
        if(isLocalPlayer)
        {
            levelcount.scorevalue = 0;
            transform.position = Vector3.zero;
        }
    }
    /*void Start()
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
            transform.position = Vector3.zero;
            levelcount.scorevalue = 1;
        }
    }*/
    public void SaveFile()
    {
        SaveToFile.SaveFile(this);
    }
    public void LoadFile()
    {
        Saving data = SaveToFile.LoadFile();
        currenthealth = data.healthlife;
    }
}
