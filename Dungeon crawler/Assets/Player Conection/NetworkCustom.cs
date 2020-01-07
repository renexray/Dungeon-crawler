using UnityEngine;
//using UnityEngine.Networking;
//using UnityEngine.Networking.NetworkSystem;
using Mirror;
using UnityEngine.UI;

public class NetworkCustom : NetworkManager
{

    public int chosenCharacter = 0;
    public GameObject[] characters;
    public GameObject choosinghero;

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
        ClientScene.AddPlayer(conn);
    }


    public override void OnClientSceneChanged(NetworkConnection conn)
    {
        //base.OnClientSceneChanged(conn);
    }

    public void btn1()
    {
        chosenCharacter = 0;
        choosinghero.SetActive(false);
    }

    public void btn2()
    {
        chosenCharacter = 1;
        choosinghero.SetActive(false);
    }

    public void btn3()
    {
        chosenCharacter = 2;
        choosinghero.SetActive(false);
    }


    public void StartupHost()
    {
        //SetPort();
        setIPAddress();
        NetworkManager.singleton.StartHost();
    }
    public void JoinGame()
    {
        setIPAddress();
        NetworkManager.singleton.StartClient();
    }
    void setIPAddress() 
    {
        string ipAddress = GameObject.Find("InputFieldIPAddress").transform.FindChild("Text").GetComponent<Text>().text;
        NetworkManager.singleton.networkAddress = ipAddress;
    }
    /*void SetPort() 
    {
        NetworkManager.singleton.networkAddress = "localhost";
    }*/
    void Menuschenebuttons() 
    {
        GameObject.Find("ButtonStartHost").GetComponent<Button>().onClick.RemoveAllListeners();
        GameObject.Find("ButtonStartHost").GetComponent<Button>().onClick.AddListener(StartupHost);

        GameObject.Find("ButtonJoinGame").GetComponent<Button>().onClick.RemoveAllListeners();
        GameObject.Find("ButtonJoinGame").GetComponent<Button>().onClick.AddListener(JoinGame);
    }
}
