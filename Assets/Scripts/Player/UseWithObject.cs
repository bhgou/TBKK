using System;
using UnityEngine;

public class UseWithObject : MonoBehaviour
{
    public static Action _onUsed;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out Outline outline))
        {
            _onUsed?.Invoke();
            outline.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Outline outline))
        {
            outline.enabled = false;
        }
    }

}
