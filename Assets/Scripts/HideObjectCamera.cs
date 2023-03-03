using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjectCamera : MonoBehaviour
{
    [SerializeField] private Shader _opacity;
    private Shader _standardShader;

    private void OnTriggerStay(Collider other)
    {
        
        _standardShader = other.gameObject.GetComponent<MeshRenderer>().material.shader;
        other.gameObject.GetComponent<MeshRenderer>().material.shader = _opacity;
    }
    private void OnTriggerExit(Collider other)
    {
        if(_standardShader != null)
            other.gameObject.GetComponent<MeshRenderer>().material.shader = _standardShader;
    }
}
