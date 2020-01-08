using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Playername : NetworkBehaviour
{

    public InputField Field;
    public Text textname;

    public void CopyText()
    {
        string inputname = Field.text;
        textname.text = inputname;
    }

    [Command]
    void CmdSendNameToServer(string nameToSend)
    {
        RpcSetPlayerName(nameToSend);
    }

    [ClientRpc]
    void RpcSetPlayerName(string name)
    {
        gameObject.transform.Find("Canvas").transform.Find("Text").GetComponent<Text>().text = name;
    }
}
