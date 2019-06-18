using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Saving
{
    public List<int> livingTargetPositions = new List<int>();
    public List<int> livingTargetsTypes = new List<int>();
    public float healthlife;
    public float health;
    public float[] position;
    public Saving(Health player)
    {
        healthlife=Health.healthlife;
    }
    public Saving(loadLevel player)
    {
        position = new float[3];
        position[0]=player.transform.position.x;
        position[1]=player.transform.position.y;
        position[2]=player.transform.position.z;
    }
    public Saving(RoomTemplates enemy)
    {
        position = new float[3];
        position[0]=enemy.transform.position.x;
        position[1]=enemy.transform.position.y;
        position[2]=enemy.transform.position.z;
    }
    public Saving(EnemyDeath enemy)
    {
        health = EnemyDeath.health;
        position = new float[3];
        position[0]=enemy.transform.position.x;
        position[1]=enemy.transform.position.y;
        position[2]=enemy.transform.position.z;
    }
}
