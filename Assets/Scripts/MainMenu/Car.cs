using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed; 
    [SerializeField] private float _lifeTime;

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
    }
}
