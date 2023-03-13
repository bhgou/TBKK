using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   private PlayerMove _playerMove;
   private bool _moving = true;
   
   public bool Moving
   {
      set => _moving = value;
   }

   [SerializeField] private List<Item> _items;
   private void Start()
   {
      _playerMove = GetComponent<PlayerMove>(); 
      
      foreach (var item in _items)
      {
         InventoryManager._instance.AddItem(item);
      }
   }

   private void Update()
   {
      if (!_moving)
      {
         _playerMove.enabled = false;
      }
      else
      {
         _playerMove.enabled = true;
      }
   }

   public void Die()
   {
      Debug.Log("Die");      
   }
}
