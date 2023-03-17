using System;
using UnityEngine;

public class UseWithObject : MonoBehaviour
{
    private Player _player;
    
    private void Start()
    {
        _player = (Player)FindObjectOfType(typeof(Player));
    }

    private void Update()
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out Outline outline))
        {
            _player.Moving = false;
            outline.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Outline outline))
        {
            outline.enabled = false;
        }
    }

}
