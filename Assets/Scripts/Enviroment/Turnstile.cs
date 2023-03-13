using System;
using UnityEngine;

public class Turnstile : MonoBehaviour
{
    private Player _player;
    
    private void Start()
    {
        _player = (Player)FindObjectOfType(typeof(Player));
    }

    private void Use()
    {
        if (InventoryManager._instance.CheckItems(0))
        {   
            _player.Moving = true;
        }
        else
        {
            _player.Moving = false;
        }
    }

    private void OnEnable()
    {
        UseWithObject._onUsed += Use;
    }

    private void OnDisable()
    {
        UseWithObject._onUsed -= Use;
    }
}
