using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject squareEnemy;
    public List <Transform> spawnLocations;
    public int randomPoint;
    public float spawnDelay;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = 0f;

        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemies();
    }

    public void SpawnEnemies()
    {
        spawnDelay -= Time.deltaTime;

        if (spawnDelay <= 0)
        {
            // Choose a random spawnpoint index 
            randomPoint = Random.Range(0, spawnLocations.Count);

            // Instantiate the enemy at the calculated position
            Instantiate(squareEnemy, spawnLocations[randomPoint].position, spawnLocations[randomPoint].rotation);
            spawnDelay = 5f;
        }
    }
}
