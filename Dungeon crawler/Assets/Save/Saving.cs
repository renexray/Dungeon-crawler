using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Saving
{
    public float healthlife;
    public int scorevalue;

    public Saving(Health player)
    {
        healthlife=Health.healthlife;
    }
    public Saving(levelcount player)
    {
        scorevalue = levelcount.scorevalue;
    }

}
