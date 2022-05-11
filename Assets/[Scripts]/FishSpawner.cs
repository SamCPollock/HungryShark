using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [Header("Gameplay Values")]
    public float minSpawnDelay;
    public float maxSpawnDelay;

    [Header("References")]
    public GameObject[] fishToSpawn;
    public GameObject fishParent;
  
    private float timeUntilSpawn;
    private float timeSinceSpawn; 

    void Start()
    {
        timeUntilSpawn = Random.Range(minSpawnDelay, maxSpawnDelay);
    }

    void Update()
    {
        timeSinceSpawn += Time.deltaTime;
        if (timeSinceSpawn > timeUntilSpawn)
        {
            SpawnFish();
        }
    }

    void SpawnFish()
    {
        GameObject newFish = Instantiate(fishToSpawn[Random.Range(0, fishToSpawn.Length)], fishParent.transform);
        newFish.transform.position = new Vector3(Random.Range(-4, 4), -2, Random.Range(-3.8f, 4));
        timeSinceSpawn = 0;
        timeUntilSpawn = Random.Range(minSpawnDelay, maxSpawnDelay);
    }
}
