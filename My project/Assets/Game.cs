using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game Instance;

    [SerializeField]
    public int MAX_ENEMIES;

    public List<UnityEngine.Object> _enemies;
    public int numEnemiesDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        _enemies = new List<UnityEngine.Object>();
    }

    // Update is called once per frame
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}
