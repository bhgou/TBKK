using System;
using System.Collections;
using UnityEngine;

public class MoveCars : MonoBehaviour
{
    [SerializeField] private Car[] _cars;
    [SerializeField] private float _speed;
    [SerializeField] private TrafficLight _trafficLight;

    private void Start()
    {
        foreach(Car car in _cars)
        {
            car.Speed = _speed;
        }
    }



    private void Update() {
        foreach(Car car in _cars){
            car.Move();
            foreach (var color in _trafficLight.Colors)
            {
                if (color.IsActive && color.NameColor == "Green")
                {
                    car.Stop();
                }
                
            }
            car.Die();
        }
        
    }
  

}
