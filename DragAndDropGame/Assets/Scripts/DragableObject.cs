using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class DragableObject : MonoBehaviour
{
    private bool _isDragging;
    private Vector2 _offset;
    private IInputReader _inputReader;

    public void SetInputReader(IInputReader inputReader)
    {
        _inputReader = inputReader;
    }

    public void MoveTo()
    {
        transform.position = _inputReader.GetPointerPosition() - _offset;
    }

    public void StartDrag()
    {   
        _offset = _inputReader.GetPointerPosition() - (Vector2)transform.position;
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