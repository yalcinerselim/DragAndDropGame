using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class DragAndDropManager : MonoBehaviour
{
    private DragableObject _currentDraggableObject;
    private IInputReader _inputReader;

    private void Awake()
    {
        _inputReader = new MouseInputReader();
    }

    private void Update()
    {
        // Mouse button down: Try to start dragging a 2D object
        if (_inputReader.IsPointerDown())
        {
            Vector2 mouseWorldPos = _inputReader.GetPointerPosition();
            RaycastHit2D hit = Physics2D.Raycast(mouseWorldPos, Vector2.zero);

            if (hit.collider != null)
            {
                DragableObject draggable = hit.collider.GetComponent<DragableObject>();
                if (draggable != null)
                {
                    _currentDraggableObject = draggable;
                    _currentDraggableObject.SetInputReader(_inputReader);
                    _currentDraggableObject.StartDrag();
                }
            }
        }
        // Mouse button held: Move the dragged object   
        if (_inputReader.IsPointerHeld() && _currentDraggableObject != null)
        {
            _currentDraggableObject.MoveTo();
        }
        // Mouse button up: Stop dragging
        if (_inputReader.IsPointerUp() && _currentDraggableObject != null)
        {
            _currentDraggableObject.StopDrag();
            _currentDraggableObject = null;
        }
    }
}