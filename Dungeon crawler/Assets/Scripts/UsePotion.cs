using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePotion : MonoBehaviour
{
    public void Use() {
        //Health.currenthealth += 20;
        Destroy(gameObject);
    }
}
