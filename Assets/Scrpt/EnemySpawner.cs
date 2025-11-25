using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject _enemyPrefab;
    public float _minimumSpawnTime;
    public float _maximumSpawnTime;
    public float _TimeUntilSpawn;
    
    void Awake()
    {
        SetTimeUntilSpawn();
    }
    void Update()
    {
        _TimeUntilSpawn -= Time.deltaTime;

        if (_TimeUntilSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    private void SetTimeUntilSpawn()
    {
        _TimeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
