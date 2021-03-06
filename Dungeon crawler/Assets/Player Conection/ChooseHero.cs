﻿using UnityEngine;
using System.Collections;
using Mirror;

public class ChooseHero : MonoBehaviour
{

    public GameObject characterSelect;

    public void PickHero(int hero)
    {
        NetworkManager.singleton.GetComponent<NetworkCustom>().chosenCharacter = hero;
        characterSelect.SetActive(false);
    }
}