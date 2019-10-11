using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
Renderer m_Renderer;
public float speed;
private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (isVisible){
        speed = 2;
        }
        else {
        speed = 0;
        }*/
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider other)
    {
    if(other.tag == "Player")
    {
        speed = 5;
    }
    }
    void OnTriggerExit(Collider other)
        {
    if(other.tag == "Player")
    {
        speed = 5;
    }
    }
}
