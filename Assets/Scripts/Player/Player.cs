using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   [SerializeField] private GameObject _panel;
   [SerializeField] private Rigidbody[] _root;

   private void Start()
   {
      foreach (var root in _root)
      {
         root.isKinematic = true;
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
