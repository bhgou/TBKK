using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "Inventory/InventoryObject", order = 0)]
public class Item : ScriptableObject
{
    [SerializeField] private int _id;

    public int Id
    {
        get => _id;
    }
    
    [SerializeField]  private Sprite _icon;

    public Sprite Icon
    {
        get => _icon;
    }
    
}
