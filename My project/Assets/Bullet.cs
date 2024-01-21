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
        }
    }

    private void Update()
    {
        if (transform.position.x > 8.5 + 1)
        {
            Destroy(gameObject);
        }
    }
}