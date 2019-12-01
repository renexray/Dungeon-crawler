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
     public void SaveFile4()
    {
        SaveToFile.SaveFile4(this);
    }
    public void LoadFile4()
    {
        Saving data = SaveToFile.LoadFile4();
        health = data.health;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }

}
