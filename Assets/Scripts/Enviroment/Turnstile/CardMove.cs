using System;
using Unity.VisualScripting;
using UnityEngine;

public class CardMove : MonoBehaviour
{
    private float speed = 10.0f;
    private float distance = 0.9f;
    private const float _maxY = 4.7f;
    private Vector3 _startPositon;
    [SerializeField] private Transform moveToCardHolder;
    [SerializeField] private Camera camera;
    [SerializeField] private Animator _openDoor;

    private void Start()
    {
        _startPositon = transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;
            Vector3 mousePos = new Vector3(mouseX, mouseY, distance);
            mousePos = camera.ScreenToWorldPoint(mousePos);
        
        
            if (transform.position != moveToCardHolder.position)
            {
            
        
           
                if (mousePos.y > _maxY)
                {
                    transform.position = Vector3.Lerp(transform.position, moveToCardHolder.position,0.25f);
                }
                else
                {
                    transform.position = Vector3.Lerp(transform.position,  mousePos, Time.deltaTime * speed);
                }
            }
            else
            {
                _openDoor.SetBool("open",true);
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, _startPositon,0.25f);
        }
        
        
        
    }

}
