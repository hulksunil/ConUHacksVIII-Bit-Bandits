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

    private List<UnityEngine.Object> _enemies;
    private int MAX_ENEMIES;

    void Start()
    {
        _enemies = Game.Instance._enemies;
        MAX_ENEMIES = Game.Instance.MAX_ENEMIES;
        // _enemies = new List<UnityEngine.Object>();
    }

    // Update is called once per frame
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0)
        {
            // limit ememies to MAX_ENEMIES
            if (_enemies.Count < MAX_ENEMIES)
            {
                // spawn enemy and add it to the list
                _enemies.Add(Instantiate(_enemy, transform.position, Quaternion.identity));
            }
            // reset timer
            SetTimeUntilSpawn();
        }

        // // loop through enemies and destroy them if they are off screen
        // for (int i = 0; i < _enemies.Count; i++)
        // {
        //     // if enemy's x coordinate is less than -12, destroy it
        //     if (((GameObject)_enemies[i]).transform.position.x < -8.5 - 1)
        //     {
        //         Destroy(_enemies[i]);

        //         Debug.Log(Game.Instance.MAX_ENEMIES - Game.Instance._enemies.Count + " enemies are left");

        //     }

        // }

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
