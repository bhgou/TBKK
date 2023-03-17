using System;
using UnityEngine;

public class Turnstile : MonoBehaviour
{
    private Player _player;
    [SerializeField] private GameObject _turnstileMenu;
    private void Start()
    {
        _player = (Player)FindObjectOfType(typeof(Player));
    }

    public void Use()
    {
        if (InventoryManager._instance.CheckItems(0))
        {
            _turnstileMenu.SetActive(true);
        }
        _player.Moving = false;
    }

}
