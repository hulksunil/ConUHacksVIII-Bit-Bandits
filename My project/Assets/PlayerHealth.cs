using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // player starts with 3 lives
    public int playerLives = 3;

    // when the player collides with an enemy, decrease the player's lives by 1
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<enemyMovement>())
        {
            playerLives--;
            Debug.Log("Player has " + playerLives + " lives left");
        }
    }


}
