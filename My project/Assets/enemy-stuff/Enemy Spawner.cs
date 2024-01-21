using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject _enemy;

    [SerializeField]
    private float _maximumSpawnTime;

    [SerializeField]
    private float _minimumSpawnTime;

    private float _timeUntilSpawn;

    // Update is called once per frame
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0)
        {
            Instantiate(_enemy, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

    void Awake()
    {
        SetTimeUntilSpawn();
    }

    private void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
