using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savingpicture : MonoBehaviour
{

    public Texture2D texture;
    Texture2D encodedTexture;
    public void SavetoPicture()
    {
        encodedTexture = picture.Encode(texture, "hi");
        Debug.Log(picture.Decode(encodedTexture));
    }
    public void LoadfromPicture()
    {
        Debug.Log(picture.Decode(encodedTexture));
    }
}
