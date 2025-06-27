using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class DragAndDropManager : MonoBehaviour
{
    private DragableObject _currentDraggableObject;

    private void Update()
    {
        // Mouse button down: Try to start dragging a 2D object
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouseWorldPos = MouseInput.GetMousePosition();
            RaycastHit2D hit = Physics2D.Raycast(mouseWorldPos, Vector2.zero);

            if (hit.collider != null)
            {
                DragableObject draggable = hit.collider.GetComponent<DragableObject>();
                if (draggable != null)
                {
                    _currentDraggableObject = draggable;
                    _currentDraggableObject.StartDrag();
                }
            }
        }
        // Mouse button held: Move the dragged object   
        if (Input.GetMouseButton(0) && _currentDraggableObject != null)
        {
            _currentDraggableObject.MoveTo();
        }
        // Mouse button up: Stop dragging
        if (Input.GetMouseButtonUp(0) && _currentDraggableObject != null)
        {
            _currentDraggableObject.StopDrag();
            _currentDraggableObject = null;
        }
    }
}