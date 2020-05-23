using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{

    public float health;

    Rigidbody2D rb;

    public GameObject explosionEffect;
    GameObject explosionEffectIns;


    float rotationX = 240;
    float rotationY = 180;


    
    EnemyControl enemyControl;

    int chooseCase;

    private void Start()
    {
        enemyControl = GameObject.Find("EnemyControl").GetComponent<EnemyControl>();
        rb = GetComponent<Rigidbody2D>();
        health = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
         
            health=0;
            Debug.Log(health);

        }

        if (collision.gameObject.tag == "texture")
        {
           
            health = 0;
        }

        if (health <= 0)
        {

            

            explosionEffectIns = Instantiate(explosionEffect, transform.position, Quaternion.identity);

            Destroy(explosionEffectIns, 10);
            
            rb.drag = 20;
            rb.angularDrag = 20;

            enemyControl.transformPosition(transform);

            health = 2;
        }
    }


}
