using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseHorn : MonoBehaviour
{
    private Transform playerPos;
    public GameObject sword;
    //public GameObject hornhead;

    private void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use() {

        Instantiate(sword, playerPos.position, sword.transform.rotation, playerPos.transform);


        //sword.SetActive(true);

        Destroy(gameObject);
    }
}
