using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

   [SerializeField] private List<Item> _items;
   private void Start()
   {
      foreach (var item in _items)
      {
         InventoryManager._instance.AddItem(item);
      }
   }

   public void Die()
   {
      Debug.Log("Die");      
   }
}
