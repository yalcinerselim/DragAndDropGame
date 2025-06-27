using UnityEngine;

public class CreateManager : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public void CreateObstacle()
    {
        Instantiate(obstaclePrefab, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0), Quaternion.identity);
        Debug.Log("Obstacle Created");
    }
}