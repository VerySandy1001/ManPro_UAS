using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] coinPrefab;

    public float minSpawnTime = 1f;
    public float maxSpawnTime = 2f;

    public float minY = -2f;
    public float minX = 1f;

    public float timer;
    public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        SetNextSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTime)
        { 
            SpawnCoin();
            timer = 0f;
            SetNextSpawnTime();
        }
    }

    void SetNextSpawnTime()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void SpawnCoin()
    { 
        float spawnX = transform.position.x;

        float spawnY = transform.position.y;

        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);
    }
}
