using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeState : MonoBehaviour
{
    [SerializeField] private BoxCollider _colliderTurnStile;
    private Player _player;

    private void Start()
    {
        _player = (Player)FindObjectOfType(typeof(Player));
    }

    public void State()
    {
        _player.Moving = true;

        _colliderTurnStile.enabled = false;
        gameObject.SetActive(false);
    }
}
