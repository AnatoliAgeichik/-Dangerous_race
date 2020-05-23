using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{

    public GameObject EndGameUI;
    public GameObject GameUI;

    public void RestartGame()
    {
        GameUI.SetActive(true);
        
        Time.timeScale = 1f;

       // Debug.Log("Restart");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        EndGameUI.SetActive(false);
    }


}
