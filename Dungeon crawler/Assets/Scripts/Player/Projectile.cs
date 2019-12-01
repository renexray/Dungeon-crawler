using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage;

   /* void OnTriggerenter2D(Collider2D col)
    {
        if (col.name !="Player")
        {
            if(col.GetComponent<EnemyDeath>()!=null)
            {
                col.GetComponent<EnemyDeath>().DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }*/
    void OnTriggerEnter2D(Collider2D c)
 {
 
     // If the object we hit is the enemy
     if (c.gameObject.tag == "enemy")

     {

         if(c.GetComponent<EnemyDeath>()!=null)
            {
                c.GetComponent<EnemyDeath>().DealDamage(damage);
            }
            Destroy(gameObject);
     }
     else if (c.gameObject.tag != "Player" && c.gameObject.tag !="Spell")
     {
         Destroy(gameObject);
     }

}
    private Vector2 target;
    public float speed;
    void Start(){
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    void Update(){
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, target)<0.2f){
            Destroy(gameObject);
        }
    }
}
