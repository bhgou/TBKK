using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMove : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] private Transform[] _points;
    [SerializeField] private int _index;
    private void Start() {
        _agent = GetComponent<NavMeshAgent>();
    }
    private void Update() {
        
        if(transform.position != _points[_index].position){
            _agent.SetDestination(_points[_index].position);
        }
        else
        {
            _index++;
            if(_index >= _points.Length){
                _index = 0;
            }
        }  
    }
}
