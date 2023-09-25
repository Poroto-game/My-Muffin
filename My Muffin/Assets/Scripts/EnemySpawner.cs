using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float _enemySpawnFrequency;
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float spawnTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        _enemySpawnFrequency = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        
        if(spawnTimer > _enemySpawnFrequency)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            spawnTimer = 0;
        }
        

    }
}
