using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleSpawnner : MonoBehaviour
{
    public GameObject[] Obstacle;
    public float spawnInterval;
    private float timer;
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;

        }
    }
    void SpawnObstacle()
    {
        if (Obstacle.Length > 0)
        {
            
            int randomIndex = Random.Range(0, Obstacle.Length);

            
            Instantiate(Obstacle[randomIndex], transform.position, Quaternion.identity);
        }
    }
}
