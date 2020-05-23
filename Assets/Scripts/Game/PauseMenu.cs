using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pauseMenuUI;
    public GameObject gameUI;



    public void Resume()
    {
        Debug.Log("Resi=ume");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameUI.SetActive(true);
    }


    public void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameUI.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
     //   Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;

    }

}
