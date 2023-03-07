using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "Inventory/InventoryObject", order = 0)]
public class Item : ScriptableObject
{
    public int Id;
    public Sprite Icon;
}
