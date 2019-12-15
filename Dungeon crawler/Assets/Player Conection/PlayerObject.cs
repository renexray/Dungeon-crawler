using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour
{
    // Start is called before the first frame update

    public GameObject playercharprefab;
    void Start()
    {
        if (isLocalPlayer == false)
        {
            return;
        }

        CmdSpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {

    }
    [Command]
    void CmdSpawnPlayer()
    {
        GameObject po = Instantiate(playercharprefab);
        NetworkServer.Spawn(po);
    }
}
