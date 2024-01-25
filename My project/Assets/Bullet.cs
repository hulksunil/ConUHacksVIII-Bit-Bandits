using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour
{

    public AudioSource audioSource;

    private void OnStart()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<enemyMovement>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Game.Instance.IncreaseNumEnemiesDestroyed();

            Debug.Log(Game.Instance.getNumEnemiesDestroyed() + " enemies were shot");

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