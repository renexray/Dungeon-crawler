using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveToFile
{
    public static void SaveFile(Health player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.oof";
        FileStream stream = new FileStream(path, FileMode.Create);

        Saving data = new Saving(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static void SaveFile2(loadLevel player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player2.oof";
        FileStream stream = new FileStream(path, FileMode.Create);

        Saving data = new Saving(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static void SaveFile3(RoomTemplates enemy)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/enemy.oof";
        FileStream stream = new FileStream(path, FileMode.Create);

        Saving data = new Saving(enemy);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static void SaveFile4(EnemyDeath enemy)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/enemy1.oof";
        FileStream stream = new FileStream(path, FileMode.Create);

        Saving data = new Saving(enemy);

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
    public static Saving LoadFile2 ()
    {
        string path = Application.persistentDataPath + "/player2.oof";
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
    public static Saving LoadFile3 ()
    {
        string path = Application.persistentDataPath + "/enemy.oof";
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
    public static Saving LoadFile4 ()
    {
        string path = Application.persistentDataPath + "/enemy1.oof";
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

}
