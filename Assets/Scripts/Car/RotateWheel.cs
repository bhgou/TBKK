using System;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
   [SerializeField] private float _speed;

   private void Update()
   {
      transform.Rotate(180 * Time.deltaTime * _speed,0,0);
   }
}
