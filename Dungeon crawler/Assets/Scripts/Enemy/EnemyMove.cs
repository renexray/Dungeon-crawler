using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
//Renderer m_Renderer;
public float speed;
private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Renderer>().isVisible){
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
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
