using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    int health=3;

    
    int highScore;
    int currentScore;
    int points;


    public GameObject endGameUI;
    public GameObject GameUI;

    public Text score;

    public Text highScoreText;
    public Text currentScoreText;
    public Text pointsUI;


    public GameObject leftHeart;
    public GameObject rightHeart;
    public GameObject miidleHeart;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.tag == "bullet")
        {
            health--;
            Debug.Log(health);
            deleteHeart();
            Debug.Log("Player");
            Debug.Log(health);

        }

        if (collision.gameObject.tag == "texture")
        {
            health = 0;
        }

        if (collision.gameObject.tag == "tank")
        {
            health = 0;

        }



        if (health <= 0)
        {
            rightHeart.SetActive(false);
            
            EndGameMenu();

        }
    }


    

    public void EndGameMenu()
    {



        // Debug.Log("leheLoh");
        //PlayerPrefs.SetInt("highScore", 0);
        points = PlayerPrefs.GetInt("Points");
        highScore = PlayerPrefs.GetInt("highScore");
        currentScore = int.Parse(score.text);
        PlayerPrefs.SetInt("Points", points + currentScore);


        Debug.Log(currentScore);

        if (highScore < currentScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("highScore", highScore);
        }

        highScoreText.text = highScore.ToString();
        

        currentScoreText.text = currentScore.ToString();
        pointsUI.text = (points + currentScore).ToString();

        endGameUI.SetActive(true);
        GameUI.SetActive(false);
        Time.timeScale = 0f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "medicine")
        {
            health = 3;
        }
    }

    void deleteHeart()
    {

        if (health == 2)
        {
            leftHeart.SetActive(false);
        }
        else if (health == 1)
        {
            miidleHeart.SetActive(false);
        }
        else
        {
            rightHeart.SetActive(false);
        }
    }

    





}
