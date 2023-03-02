using System;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float _speed;
    private float _halfSpeed;
    private float _maxDistance = 8;
    [SerializeField] private Transform _rayPos;
    [SerializeField] private bool _moving;

    public float Speed{get{
        return _speed;
    }set{
        _speed = value;   
    }}

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

   
    public void Move()
    {
        _moving = true;
    }

    public void Stop()
    {
        RaycastHit hit;
        if (Physics.Raycast(_rayPos.position, _rayPos.TransformDirection(Vector3.forward), out hit, 5))
        {
            if (hit.collider.CompareTag("Stop"))
            {
                _moving = false;
            }
        }
    }
    public void Die(){
        
        RaycastHit hit;
        if (Physics.Raycast(_rayPos.position, _rayPos.TransformDirection(Vector3.forward), out hit, 10))
        {
            if (hit.collider.CompareTag("End"))
            {
                transform.position = _startPosition;
            }
        }
        
    }

    private void Update() {
        if (_moving)
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
        RaycastHit hit;
        if (Physics.Raycast(_rayPos.position, _rayPos.TransformDirection(Vector3.forward), out hit, _maxDistance))
        {
            if (hit.collider.TryGetComponent(out Player player))
            {
                player.Die();
            }
        }

        Debug.DrawRay(_rayPos.position, _rayPos.TransformDirection(Vector3.forward) * _maxDistance, Color.yellow);
    }

   
}
