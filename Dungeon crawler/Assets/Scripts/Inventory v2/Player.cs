using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    // Start is called before the first frame update

    public void OnTriggerEnter2D(Collider2D other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            Item _item = new Item(item.item);
            inventory.AddItem(_item, 1);
            Destroy(other.gameObject);
        }
    }
    
    private void OnApplicationQuit()
    {
        inventory.Container.Items = new InventorySlot[25];
    }
}
