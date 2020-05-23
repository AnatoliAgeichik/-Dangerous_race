using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject explosionEffect;
    GameObject explosionEffectIns;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "tank")
        {
            
            Debug.Log(gameObject);
            DestroyBullet();

        }

        if (collision.gameObject.tag == "Player")
        {
          
            DestroyBullet();
        }

        if (collision.gameObject.tag == "texture")
        {
            
            DestroyBullet();
        }
    }


    private void DestroyBullet()
    {
        explosionEffectIns = Instantiate(explosionEffect, transform.position, Quaternion.identity);

        Destroy(explosionEffectIns, 10);

        Destroy(gameObject);
    }


}
