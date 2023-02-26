using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float _speed; 
    private float _lifeTime;
    private float _maxDistance = 5;
    [SerializeField] private Transform _rayPos;
    public float LifeTime{
        get{
            return _lifeTime;
        }
        set{
            _lifeTime = value;
        }
    }

    public float Speed{get{
        return _speed;
    }set{
        _speed = value;   
    }}

    private Vector3 _startPosition;

    private void Start() {
        _lifeTime = FindObjectOfType<MoveCars>().LifeTime;
        _startPosition = transform.position;
    }

   
    public void Move(){
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    public void Die(){
        _lifeTime = FindObjectOfType<MoveCars>().LifeTime;
        transform.position = _startPosition;
    }

    private void Update() {
        if(_lifeTime > 0){
            _lifeTime -= 1 * Time.deltaTime;
        }
        RaycastHit hit;
        if (Physics.Raycast(_rayPos.position, _rayPos.TransformDirection(Vector3.forward), out hit, _maxDistance))
        {
            if (hit.collider.TryGetComponent(out Player player))
            {
                player.Die();
                _speed = 0;
            }
        }

        Debug.DrawRay(_rayPos.position, _rayPos.TransformDirection(Vector3.forward) * _maxDistance, Color.yellow);
    }

   
}
