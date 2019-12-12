using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class levelcount : MonoBehaviour
{

    static readonly string SAVE_FILE = "player.dat";
    //01234567890123456789012345678901
    static readonly string JSON_ENCRYPTED_KEY = "#kJ83DAlowjkf39(#($%0_+[]:#dDA'a";



    public static int scorevalue = 1;
    Text score;
    // Start is called before the first frame update
    public void Start()
    {
        score = GetComponent<Text>();
        scorevalue = 1;
    }


    public void datasave()
    {
        /*SaveData data = new SaveData();

        data.score = scorevalue;*/
        SaveData saveData = new SaveData();

        saveData.scorevalue = scorevalue;

        string json = JsonUtility.ToJson(saveData);

        Rijndael crypto = new Rijndael();
        byte[] soup = crypto.Encrypt(json, JSON_ENCRYPTED_KEY);

        string filename = Path.Combine(Application.persistentDataPath, SAVE_FILE);

        if (File.Exists(filename))
        {
            File.Delete(filename);
        }

        File.WriteAllBytes(filename, soup);

    }
    public void dataload() 
    {
        Rijndael crypto = new Rijndael();
        string filename = Path.Combine(Application.persistentDataPath, SAVE_FILE);
        byte[] soupBackIn = File.ReadAllBytes(filename);
        string jsonFromFile = crypto.Decrypt(soupBackIn, JSON_ENCRYPTED_KEY);
        SaveData copy = JsonUtility.FromJson<SaveData>(jsonFromFile);
        scorevalue = copy.scorevalue;
        Debug.Log(copy.scorevalue);
    }
    // Update is called once per frame
    public void Update()
    {
        score.text = "HighScore: " + scorevalue;
    }
    public void SaveFile3()
    {
        SaveToFile.SaveFile3(this);
    }
    public void LoadFile3()
    {
        Saving data = SaveToFile.LoadFile3();
        scorevalue = data.scorevalue;
    }
}
