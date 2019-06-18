using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePotion : MonoBehaviour
{
    

    public void Use() {
        Health.healthlife +=20f;
        Destroy(gameObject);
    }
}
