using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class DragableObject : MonoBehaviour
{
    private bool _isDragging;
    private Vector2 _offset;
    
    public void MoveTo()
    {
        transform.position = MouseInput.GetMousePosition() - _offset;
    }

    public void StartDrag()
    {   
        _offset = MouseInput.GetMousePosition() - (Vector2)transform.position;
        _isDragging = true;
    }

    public void StopDrag()
    {
        _isDragging = false;
    }

    private void Update()
    {
        if (!_isDragging) return;

        MoveTo();
    }
}