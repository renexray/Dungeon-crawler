using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Spawner : NetworkBehaviour
{
    [SerializeField] GameObject enemyprefab;
    [SerializeField] GameObject enemypawn;
    // Start is called before the first frame update
    private int counter;
    private int numberofenemy = 1;

    public override void OnStartServer()
    {
        for (int i = 0; i < numberofenemy; i++)
        {
            spawnenemy();
        }
    }
    void spawnenemy()
    {
        GameObject go = GameObject.Instantiate(enemyprefab, enemypawn.transform.position, Quaternion.identity) as GameObject;
        NetworkServer.Spawn(go);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
