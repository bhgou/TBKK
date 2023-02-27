using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material _color;

    public void SetColor(){
        GetComponent<MeshRenderer>().material = _color;
    }

}
