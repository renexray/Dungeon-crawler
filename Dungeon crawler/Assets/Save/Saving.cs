using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Saving
{
    public int healthlife;
    public int scorevalue;

    public Saving(Health player)
    {
        //healthlife=Health.currenthealth;
    }
    public Saving(levelcount player)
    {
        scorevalue = levelcount.scorevalue;
    }

}
