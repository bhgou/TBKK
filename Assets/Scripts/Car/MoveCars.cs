using System;
using System.Collections;
using UnityEngine;

public class MoveCars : MonoBehaviour
{
    [SerializeField] private Car[] _cars;
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;

    private void Start()
    {
        foreach(Car car in _cars)
        {
            car.Speed = _speed;
        }
    }

    public float LifeTime{
        get{
            return _lifeTime;
        }
        set{
            _lifeTime = value;
        }
    }

    private void Update() {
        foreach(Car car in _cars){
            car.Move();
            if(car.LifeTime <= 0){
                car.Die();
            }
        }
        
    }
  

}
