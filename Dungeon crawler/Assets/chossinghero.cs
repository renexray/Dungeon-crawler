using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chossinghero : MonoBehaviour
{
    public GameObject Ghost;
    public GameObject Knight;
    public GameObject Wizzard;
    public GameObject Archer;
    public GameObject GhostCanvas;
    public GameObject KnightCanvas;
    public GameObject WizzardCanvas;
    public GameObject ArcherCanvas;

    public void Knightpick()
    {
        Ghost.SetActive(false);
        GhostCanvas.SetActive(false);
        Knight.SetActive(true);
        KnightCanvas.SetActive(true);
    }
    public void Wizzardpick()
    {
        Ghost.SetActive(false);
        GhostCanvas.SetActive(false);
        Wizzard.SetActive(true);
        WizzardCanvas.SetActive(true);
    }
    public void Archerpick()
    {
        Ghost.SetActive(false);
        GhostCanvas.SetActive(false);
        Archer.SetActive(true);
        ArcherCanvas.SetActive(true);
    }
}
