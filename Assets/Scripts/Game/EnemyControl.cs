using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyControl : MonoBehaviour
{


    public GameObject enemyPrefab;
    public int countEnemy ;
    public Text score;

    Vector3 position;
    Quaternion rotation;

    float rotationX = 240;
    float rotationY = 180;

    int chooseCase;
    public GameObject player;

    private void Start()
    {
        for (int i = 0; i < countEnemy; i++)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), 0), Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))));
        }
    }


    private void Update()
    {
        if (countEnemy< int.Parse(score.text))
        {
            createEnemy();

            countEnemy++;
        }
    }


    public Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-rotationX, rotationX), Random.Range(-rotationY, rotationY),0);
    }

    public Quaternion getRandomRotation()
    {
        
        return  Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360)));
    }


   public void createEnemy()
    {
        position = getRandomPosition();
        rotation = getRandomRotation();
        Instantiate(enemyPrefab, position, rotation);
    }



    // Start is called before the first frame update
   
    public void transformPosition(Transform tank)
    {
        chooseCase = Random.Range(0, 4);
        switch (chooseCase)
        {
            case 0:
                tank.position = new Vector3(Random.Range(-rotationX, player.transform.position.x - 20), Random.Range(-rotationY, player.transform.position.y - 20), 0);
                break;
            case 1:
                tank.position = new Vector3(Random.Range(-rotationX, player.transform.position.x - 20), Random.Range(player.transform.position.y + 20, rotationY), 0);
                break;
            case 2:
                tank.position = new Vector3(Random.Range(player.transform.position.x + 20, rotationX), Random.Range(player.transform.position.y + 20, rotationY), 0);

                break;
            case 3:
                tank.position = new Vector3(Random.Range(player.transform.position.x + 20, rotationX), Random.Range(-rotationY, player.transform.position.y - 20), 0);

                break;
        }
        
    }


}
