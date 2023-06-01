using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxSpawner : MonoBehaviour
{

    [SerializeField] private Transform[] spawnPoints;

    [SerializeField] private GameObject blockPrefab;

    [SerializeField] private float timeBetweenSpawns = 100f;

    private float timeToSpawn = 2f;

    // Start is called before the first frame update
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {

            spawnBlocks();
            timeToSpawn = Time.time + timeBetweenSpawns;
        }
    }

    private void spawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        int randomIndex2 = Random.Range(0, spawnPoints.Length);

        if(randomIndex == randomIndex2 && randomIndex2 == spawnPoints.Length-1)
        { 
            randomIndex2 = randomIndex2 - Random.Range(1,3);
        } 
        else if(randomIndex == randomIndex2 && randomIndex2 == 0)
        {
            randomIndex2 = randomIndex2 + Random.Range(1,3);
        }

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i && i != randomIndex2)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
