using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicine : MonoBehaviour
{
    float randomX = 240;
    float randomY = 180;


    public GameObject leftHeart;
    public GameObject middleHeart;


    Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-randomX, randomX), Random.Range(-randomY, randomY), 0);
    }


    private void Start()
    {

        transform.position = getRandomPosition();

    }



    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            
            //Debug.Log(score.text);
            transform.position = getRandomPosition();
            plusHealth();
            


        }

        if (collider.gameObject.tag == "texture")
        {
            transform.position = getRandomPosition();

        }


    }

    void plusHealth()
    {
        middleHeart.SetActive(true);
        leftHeart.SetActive(true);
    }

}


