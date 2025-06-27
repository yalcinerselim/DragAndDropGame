using UnityEngine;

public interface IInputReader
{
    bool IsPointerDown();
    bool IsPointerUp();
    bool IsPointerHeld();
    Vector2 GetPointerPosition();
}
