using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveToFile
{
    static readonly string SAVE_FILE = "player.dat";
                                               //01234567890123456789012345678901
    static readonly string JSON_ENCRYPTED_KEY = "#kJ83DAlowjkf39(#($%0_+[]:#dDA'a";

    /*void Start()
    {
        string json = JsonUtility.ToJson(data);

        Rijndael crypto = new Rijndael();
        byte[] soup = crypto.Encrypt(json, JSON_ENCRYPTED_KEY);

        string filename = Path.Combine(Application.persistentDataPath, SAVE_FILE);

        if (File.Exists(filename))
        {
            File.Delete(filename);
        }

        File.WriteAllBytes(filename, soup);
    }*/
    public static void SaveFile(Health player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.oof";
        FileStream stream = new FileStream(path, FileMode.Create);

        Saving data = new Saving(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static void SaveFile3(levelcount player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player3.oof";
        FileStream stream = new FileStream(path, FileMode.Create);

        Saving data = new Saving(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static Saving LoadFile ()
    {
        string path = Application.persistentDataPath + "/player.oof";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            Saving data = formatter.Deserialize(stream) as Saving;
            stream.Close();
            return data;

        }else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    public static Saving LoadFile3()
    {
        string path = Application.persistentDataPath + "/player3.oof";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            Saving data = formatter.Deserialize(stream) as Saving;
            stream.Close();
            return data;

        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

}
