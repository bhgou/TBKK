using System;
using UnityEngine;

public class Turnstile : UseItemInventoryObject
{
    [SerializeField] private int id;
    private Player _player;
    [SerializeField] private GameObject _turnstileMenu;
    private void Start()
    {
        _player = (Player)FindObjectOfType(typeof(Player));
    }
    
    public override void Use()
    {
        if (InventoryManager._instance.ChooseItemIsPick(id))
        {
            _turnstileMenu.SetActive(true);
        }
        _player.Moving = false;
    }

}
