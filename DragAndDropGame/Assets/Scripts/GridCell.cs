using UnityEngine;

public enum CellType
{
    Empty,
    Obstacle,
    Player,
    Food,
    Tail
}

public class GridCell : MonoBehaviour
{
    private CellType _cellType;
    private Vector2Int _gridPosition;
    private GameObject _gameObject;

    public void GridCell(CellType cellType, Vector2Int gridPosition, GameObject gameObject)
    {
        _cellType = cellType;
        _gridPosition = gridPosition;
        _gameObject = gameObject;
    }
}
