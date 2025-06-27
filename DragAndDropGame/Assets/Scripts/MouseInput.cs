using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public static Vector2 GetMousePosition()
    {
        return (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}