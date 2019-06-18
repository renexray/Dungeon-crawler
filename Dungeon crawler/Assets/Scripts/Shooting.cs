using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectile;
    /*
    public float minDamage;
    public float maxDamage;
    public float projectileForce;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bubble = Instantiate(projectile,transform.position, Quaternion.identity);
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mousePos).normalized;
            bubble.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            bubble.GetComponent<Projectile>().damage=Random.Range(minDamage, maxDamage);
            //Physics2D.IgnoreCollision(bubble.GetComponent<Collider2D>(),  GetComponent<Collider2D>());
        }
    }*/
    
    private Transform playerPos;
    void Start()
    {
        playerPos=GetComponent<Transform>();
    }
    void Update(){
        if (Input.GetMouseButtonDown(0)){
            Instantiate(projectile,playerPos.position,Quaternion.identity);
        }
    }
    
}
