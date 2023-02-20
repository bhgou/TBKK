using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    private float _speed = 2f;
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _deadPosition;
    private void FixedUpdate() {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        if(gameObject.transform.position == _deadPosition.position){
            Debug.Log("Trigger");
            gameObject.transform.position = _startPosition.position;  
        }
    }

    // private void OnTriggerEnter(Collider other) {
    //     if(other.CompareTag("End")){
    //         gameObject.transform.position = _startPosition.position;
    //     }
    // }
}
