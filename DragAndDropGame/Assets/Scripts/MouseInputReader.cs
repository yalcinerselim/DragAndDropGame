using UnityEngine;

public class MouseInputReader : IInputReader
{
    public Vector2 GetPointerPosition()
    {
        return (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public bool IsPointerDown() => Input.GetMouseButtonDown(0);

    public bool IsPointerUp() => Input.GetMouseButtonUp(0);

    public bool IsPointerHeld() => Input.GetMouseButton(0);
}