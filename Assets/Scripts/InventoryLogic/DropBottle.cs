using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBottle : UseItemInventoryObject
{
    [SerializeField] private int _id = 1;
    
    public override void Use()
    {
        if (InventoryManager._instance.ChooseItemIsPick(_id))
        {
            InventoryManager._instance.RemoveItem(_id);
        }
        
    }
}
