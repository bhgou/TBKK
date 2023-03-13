using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
   private PlayerMove _playerMove;
   private bool _moving = true;
   
   public bool Moving
   {
      set => _moving = value;
   }
=======
   [SerializeField] private GameObject _panel;
   [SerializeField] private Rigidbody[] _root;
>>>>>>> parent of 884f2c92 (secondLevel1)

   private void Start()
   {
<<<<<<< HEAD
      _playerMove = GetComponent<PlayerMove>(); 
      
      foreach (var item in _items)
=======
      foreach (var root in _root)
>>>>>>> parent of 884f2c92 (secondLevel1)
      {
         root.isKinematic = true;
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
      _panel.SetActive(true);
      foreach (var root in _root)
      {
         root.isKinematic = false;
      }
      
   }
}
