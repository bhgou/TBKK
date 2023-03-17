
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    private Vector3 offset;
    private Transform target;
    private Vector3 initialPosition;
    
    [SerializeField] private Item _item;
    private bool _followToMouse;
    private bool _draging;
    private Vector3 _startPosition;
    private Player _player;

    public Item Item
    {
        set
        {
            _item = value;
        }
        get
        {
            return _item;
        }
    }

    private void Start()
    {
        _player = (Player)FindObjectOfType(typeof(Player));
        _startPosition = transform.position;
    }

    private void Update()
    {
        
        
        if (_item != null)
        {
            GetComponent<Image>().sprite = _item.Icon;
        }
        else
        {
            GetComponent<Image>().sprite = null;
        }

        if (_draging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;
            Vector3 mousePos = new Vector2(mouseX, mouseY);
            transform.position = mousePos;
            _player.Moving = false;
            if (Input.GetMouseButton(0))
            {
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    if (hit.collider.gameObject.TryGetComponent(out Turnstile turnstile))
                    {
                        turnstile.Use();
                    }
                }
                
                transform.position = _startPosition;
                _draging = false;
                _player.Moving = true;
            }
        }
    }
    
    public void MoveToMouse()
    {
        _draging = true;
    }
    

}
