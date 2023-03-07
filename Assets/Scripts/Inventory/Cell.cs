
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    private Item _item;

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
    }
}
