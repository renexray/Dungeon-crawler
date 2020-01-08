using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D coll)
    {
        GameObject hit = coll.gameObject;
        Health health = hit.GetComponent<Health>();
        //if (coll.gameObject.tag == "Player")
        //{
            if (health!=null)
            {
                health.Takedamage(30);
            }
       // }
    }

}
