<<<<<<< HEAD
using System;
=======
>>>>>>> b2437b6edf3ede5f19eee4ff74996896783f3a4b
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjectCamera : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
>>>>>>> b2437b6edf3ede5f19eee4ff74996896783f3a4b
    }
}
