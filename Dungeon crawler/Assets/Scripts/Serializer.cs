using UnityEngine;
using System.Collections;
using System.IO;

public class Serializer : MonoBehaviour
{
    static readonly string SAVE_FILE = "player.dat";
                                               //01234567890123456789012345678901
    static readonly string JSON_ENCRYPTED_KEY = "#kJ83DAlowjkf39(#($%0_+[]:#dDA'a";

    public GameObject player;

    void Start()
    {
        SaveData data = new SaveData()
        {
            name = "Sloan",
            armour = 5,
            items = new System.Collections.Generic.List<string>(),
            position = player.transform.position,
            rotation = player.transform.rotation
        };

        data.items.Add("Sword");
        data.items.Add("Shield");
        data.items.Add("Potion");

        string json = JsonUtility.ToJson(data);

        Rijndael crypto = new Rijndael();
        byte[] soup = crypto.Encrypt(json, JSON_ENCRYPTED_KEY);

        string filename = Path.Combine(Application.persistentDataPath, SAVE_FILE);

        if (File.Exists(filename))
        {
            File.Delete(filename);
        }

        File.WriteAllBytes(filename, soup);

        //Debug.Log("Player saved to " + filename);

        //string jsonFromFile = File.ReadAllText(filename);
        byte[] soupBackIn = File.ReadAllBytes(filename);
        string jsonFromFile = crypto.Decrypt(soupBackIn, JSON_ENCRYPTED_KEY);

        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
        Debug.Log(copy.name);

        //player.transform.position = copy.position;
        //player.transform.rotation = copy.rotation;



    }


    


}
