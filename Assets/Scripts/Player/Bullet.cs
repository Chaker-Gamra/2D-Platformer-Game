using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            AudioManager.instance.Play("EnemyDamage");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
            
    }
}
