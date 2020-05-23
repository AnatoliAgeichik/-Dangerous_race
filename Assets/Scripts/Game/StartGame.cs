using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject RockPrefab1;
    public GameObject RockPrefab2;
    //public GameObject RockPrefab3;
    public GameObject woodBoxPrefab;
    public GameObject metalBoxPrefab;
    public GameObject bushPrefab;


    float rotationX = 240;
    float rotationY = 180;

    public int countRock1;
    public int countRock2;
   // public int countRock3;
    public int countWoodBox;
    public int countMetalBox;
    public int countBush;

    float playerX=0.2f;
    float playerY=0.03f;

    int chooseCase;
    
    void Start()
    {
        
        for(int i=0; i < countRock1; i++)
        {
            Instantiate(RockPrefab1, getRandomPosition(), getRandomRotation());
        }

        for (int i = 0; i < countRock2; i++)
        {
            Instantiate(RockPrefab2, getRandomPosition(), getRandomRotation());
        }
       

        for (int i = 0; i < countWoodBox; i++)
        {
            Instantiate(woodBoxPrefab, getRandomPosition(), getRandomRotation());
        }

        for (int i = 0; i < countMetalBox; i++)
        {
            Instantiate(metalBoxPrefab, getRandomPosition(), getRandomRotation());
        }

        for (int i = 0; i < countBush; i++)
        {
            Instantiate(bushPrefab, getRandomPosition(), getRandomRotation());
        }
    }

    Vector3 getRandomPosition()
    {
        chooseCase = Random.Range(0, 4);
        switch (chooseCase)
        {
            case 0:
                return new Vector3(Random.Range(-rotationX, playerX - 20), Random.Range(-rotationY, playerY - 20), 0);
                break;
            case 1:
                return new Vector3(Random.Range(-rotationX, playerX - 20), Random.Range(playerY + 20, rotationY), 0);
                break;
            case 2:
                return new Vector3(Random.Range(playerX + 20, rotationX), Random.Range(playerY + 20, rotationY), 0);

                break;
            case 3:
                return new Vector3(Random.Range(playerX + 20, rotationX), Random.Range(-rotationY, playerY - 20), 0);

                break;
        }
        return new Vector3(Random.Range(-240f, 240f), Random.Range(-180f, 180f), 0);
    }

    Quaternion getRandomRotation()
    {

        return Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360)));
    }


    // Update is called once per frame

}
