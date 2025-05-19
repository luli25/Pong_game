using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;

    [SerializeField]
    private float timeToSpawn;

    private GameObject obstacleInstance;
    private float respawnTime = 2.0f;
    private bool gameStart = false;

    void Start()
    {
        gameStart = true;
        Debug.Log(gameStart);
        StartCoroutine(ObstaclesWave());
    }

    private void SpawnObstacles()
    {
        float randomX = Random.Range(4f, -5f);
        float randomY = Random.Range(4f, -2f);
        float timeToDestroy = Random.Range(3f, 8f);

        obstacleInstance = Instantiate(obstaclePrefab, new Vector2(randomX, randomY), Quaternion.identity);
        Destroy(obstacleInstance, timeToDestroy);
    }

    IEnumerator ObstaclesWave()
    {
        while (gameStart)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnObstacles();
        }
    }
}
