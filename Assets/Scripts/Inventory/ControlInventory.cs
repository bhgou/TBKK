using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlInventory : MonoBehaviour
{
    [SerializeField] private Item _item;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InventoryManager._instance.AddItem(_item);
        }
        if (Input.GetMouseButtonDown(1))
        {
            InventoryManager._instance.RemoveItem(_item);
        }
    }
}
