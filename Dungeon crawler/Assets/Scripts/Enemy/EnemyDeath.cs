using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
   public static float health;
   public float maxhealth;
   public GameObject lootdrop;

    void Start()
    {
        health=maxhealth;
        
    }
    public void DealDamage(float dammage)
    {
        health = health - 20;
        CheckDeath();
    }
    /*void Update()
    {   for(int i=0; i < health; i++)
        {
            health = health -1;
            CheckDeath();

        }
    }*/
    private void CheckDeath()
    {
        if (health <= 0 )
        {
            Destroy(gameObject);
            Instantiate(lootdrop, transform.position, Quaternion.identity);
        }
    }

}
