using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class shootmp : NetworkBehaviour
{/*
    public GameObject projectile;
    private Transform playerPos;

    [Client]
    void Update()
    {

        if (!base.hasAuthority)
        {
            return;
        }
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
        
     
    void Fire()
    {
        Vector2 _target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Vector2 _myPos = new Vector2(transform.position.x, transform.position.y + 1);
        Vector2 _myDir = _target - _myPos;
        Vector3 _rot = transform.rotation.eulerAngles;

        CmdFire(_myPos, _myDir, _rot);
    }
    [Command]
    void CmdFire(Vector2 _myPos, Vector2 _myDir, Vector3 _rot)
    {
        RpcFire(_myPos, _myDir, _rot);
    }

    [ClientRpc]
    void RpcFire(Vector2 _myPos, Vector2 _myDir, Vector3 _rot)
    {
        // create the bullet object from the bullet prefab

        // make the bullet move away in front of the player

        GameObject _projectile = (GameObject)Instantiate(projectile, _myPos, Quaternion.Euler(_rot));
        _projectile.GetComponent<Rigidbody2D>().velocity = _myDir * 4f;

        // spawn the bullet on the clients
        NetworkServer.Spawn(_projectile);

        // make bullet disappear after 2 seconds
        Destroy(_projectile, 2.0f);
    }
*/}
