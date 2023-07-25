using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    [SerializeField] Transform Player;
    [SerializeField] List<GameObject> SpawnedObstacles;

    [SerializeField] int distanceBetweenTwoObstacles = 8;

    private Vector2 SpawnPoint = new Vector2(-4, 0);

    private void Start()
    {
        //Spawn random 10 obstacles in start
        for(int i = 1; i <= 10; i++)
        {
            SpawnObstacle();
        }
    }

    private void Update()
    {
        //Check if obstacle is behind player
        
        if(SpawnedObstacles[0].transform.position.x <= (Player.position.x - 30))
        {
            GameObject tempObj = SpawnedObstacles[0];
            SpawnedObstacles.Remove(SpawnedObstacles[0]);
            Destroy(tempObj);

            SpawnObstacle();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
        }
        
    }

    private void SpawnObstacle()
    {
        SpawnPoint = new Vector2(SpawnPoint.x + distanceBetweenTwoObstacles, 0f);

        GameObject InstatiatedObstacle = Instantiate(obstacle, SpawnPoint, Quaternion.identity, transform);
        SpawnedObstacles.Add(InstatiatedObstacle);
    }
}
