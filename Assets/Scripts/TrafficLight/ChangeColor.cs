using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material _color;
    [SerializeField] private string _nameColor;
    [SerializeField] private bool _isActive;
    public bool IsActive
    {
        get { return _isActive; }
        set { _isActive = value; }
    }
    public string NameColor{
        get{
            if (_nameColor != "")
            {
                return _nameColor;
            }
            else
            {
                return "Red";
            }
        
        }
        
        
    }
    public void SetColor()
    {
        _isActive = true;
        GetComponent<MeshRenderer>().material = _color;
    }

 
}
