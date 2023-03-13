using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{


   public static InventoryManager _instance = null;
   
   
   [SerializeField] private Cell[] _cells;
   private int _indexCell = -1;

   private void Start()
   {
      if (_instance == null)
      {
         _instance = this;
      }
      else if(_instance == this)
      {
         Destroy(gameObject);
      }
      
      DontDestroyOnLoad(gameObject);
   }


   public void AddItem(Item item)
   {
      _indexCell++;
      if (_indexCell < _cells.Length && _indexCell >= 0)
      {
         _cells[_indexCell].Item = item;
      }
      else
      {
         _indexCell = 0;  
      }

   }

   public bool CheckItems(int id)
   {
      var haveItem = false;
      
      foreach (var cell in _cells)
      {
         if(cell.Item != null){
            if (cell.Item.Id == id)
            {
               haveItem = true;
            }
            else
            {
               haveItem = false;
            }
            
         }
      }
      return haveItem;
   }
   public void RemoveItem(Item item)
   {
      _cells[_indexCell].Item = null;
      _indexCell--;
   }

}
