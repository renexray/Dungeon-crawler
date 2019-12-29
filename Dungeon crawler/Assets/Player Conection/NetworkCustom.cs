using UnityEngine;
//using UnityEngine.Networking;
//using UnityEngine.Networking.NetworkSystem;
using Mirror;

public class NetworkCustom : NetworkManager
{

    public int chosenCharacter = 0;
    public GameObject[] characters;

    //subclass for sending network messages
    public class NetworkMessage : MessageBase
    {
        public int chosenClass;
    }

    public override void OnServerAddPlayer(NetworkConnection conn, AddPlayerMessage extraMessage)
    {

        GameObject player;
        Transform startPos = GetStartPosition();

        if (startPos != null)
        {
            player = Instantiate(characters[chosenCharacter], startPos.position, startPos.rotation) as GameObject;
        }
        else
        {
            player = Instantiate(characters[chosenCharacter], Vector3.zero, Quaternion.identity) as GameObject;

        }

        NetworkServer.AddPlayerForConnection(conn, player);

    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        NetworkMessage test = new NetworkMessage();
        test.chosenClass = chosenCharacter;

        ClientScene.AddPlayer(conn);
    }


    public override void OnClientSceneChanged(NetworkConnection conn)
    {
        //base.OnClientSceneChanged(conn);
    }

    public void btn1()
    {
        chosenCharacter = 0;
    }

    public void btn2()
    {
        chosenCharacter = 1;
    }
}
