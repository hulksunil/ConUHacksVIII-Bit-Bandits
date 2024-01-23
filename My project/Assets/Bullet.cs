using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<enemyMovement>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Game.Instance.numEnemiesDestroyed++;

            Debug.Log(Game.Instance.numEnemiesDestroyed + " enemies were shot");

        }
    }

    private void Update()
    {
        // if bullet is off screen, destroy it
        if (transform.position.x > 8.5 + 1)
        {
            Destroy(gameObject);
        }
    }
}