using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerObject : NetworkBehaviour
{


    //public GameObject cam;
    private float movementSpeed = 5f;
    public GameObject projectile;
    private Transform playerPos;
    void Start()
    {
        playerPos = GetComponent<Transform>();
    }
    [Client]
    void Update()
    {

        if (!base.hasAuthority)
        {
            return;
        }
        float x = Input.GetAxis("Horizontal") * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * Time.deltaTime;


        Vector3 tempVect = new Vector3(x, z, 0);
        tempVect = tempVect.normalized * movementSpeed * Time.deltaTime;

        this.transform.position += tempVect;

        if (Input.GetMouseButtonDown(0))
        {
            CmdFire();
        }
    }
    [Command]
    void CmdFire()
    {
        Instantiate(projectile, playerPos.position, Quaternion.identity);
        GameObject item = (GameObject)Instantiate(projectile, playerPos.position, Quaternion.identity);
        NetworkServer.Spawn(item);
    }

}
