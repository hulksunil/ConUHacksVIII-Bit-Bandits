using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Awake(){
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D collision){
        Destroy(collision.gameObject);
        Destroy(gameObject);

    }
}
