using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Declares attachment to the enemy prefabs or something
    public GameObject[] enemyPrefabs;

    // Declares spawn range and intervals
    private float spawnRangeX = 10;
    private float spawnPosZ = 8;
    private float startDelay = 2;
    private float spawnInterval = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        // Spawns random enemy at certain intervals
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Method to random enemy in random positions
    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
    
}
