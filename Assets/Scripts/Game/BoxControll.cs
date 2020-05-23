using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControll : MonoBehaviour
{


    public GameObject boxPrefab;
    float randomX = 50;    
    float randomY = 50;

     Quaternion quaternion = Quaternion.Euler(new Vector3(0, 0, 0));


    Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-randomX, randomX), Random.Range(-randomY, randomY), 0);
    }



    void Start()
    {

        Instantiate(boxPrefab, getRandomPosition(), quaternion);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    






}
