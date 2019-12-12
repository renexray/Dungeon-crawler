using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelcount : MonoBehaviour
{
    public static int scorevalue = 1;
    Text score;
    // Start is called before the first frame update
    public void Start()
    {
        score = GetComponent<Text>();
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
