using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _point;
    [SerializeField] private Vector3 _input;
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position,
            new Vector3(_point.position.x, transform.position.y, _point.position.z), Time.deltaTime * _speed);
        if (Input.GetMouseButtonDown(0))
        {
            _point.transform.position = transform.position + _input;
        }
    }
}