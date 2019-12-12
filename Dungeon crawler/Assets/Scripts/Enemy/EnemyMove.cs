using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{/*
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

    void OnTriggerEnter2D(Collider2D other)
    {
        speed = 0;
        speed = 2;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        speed = 0;
        speed = 2;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        /*if (other.tag == "Player")
    {
        speed = 6;
            Debug.Log(speed);
    }
    }*/
 // Who we are chasing
    private Transform Player;

    // how fast we want the enemy to chase
    public float ChaseSpeed = 5f;

    // the range at which it detects Player
    public float Range = 5f;

    // what our current speed is (get only)
    float CurrentSpeed;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        // put this in under Update()
        if (Vector2.Distance(transform.position, Player.position) <= Range) // check the distance between this game object and Player and continue if it's less than Range
        {
            CurrentSpeed = ChaseSpeed * Time.deltaTime; // set the CurrentSpeed to ChaseSpeed and multiply by Time.deltaTime (this prevents it from moving based on FPS)
            transform.position = Vector3.MoveTowards(transform.position, Player.position, CurrentSpeed);  // set this game objects position to the Player's position at the speed of CurrentSpeed
        }
    }
}
