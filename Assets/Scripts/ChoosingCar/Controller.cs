using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    public GameObject standartCar;
    public GameObject sportCar;
    public GameObject pickup;

    GameObject nowCar;

    int nowIndex;

    Dictionary<int, GameObject> cars = new Dictionary<int, GameObject>(3);


    private void Start()
    {
        cars.Add(0, standartCar);
        cars.Add(1, sportCar);
        cars.Add(2, pickup);
        nowIndex = 0;
    }


    public void RightBtn()
    {
        cars[nowIndex].SetActive(false);

        if (nowIndex == cars.Count - 1)
        {
            nowIndex = 0;
        }
        else
        {
            nowIndex++;
        }
        Debug.Log("veselo");
        Debug.Log(nowIndex);
        cars[nowIndex].SetActive(true);


    }
    public void LeftBtn()
    {
        cars[nowIndex].SetActive(false);


        if (nowIndex == 0)
        {
            nowIndex = cars.Count-1;
        }
        else
        {
            nowIndex--;
        }

        cars[nowIndex].SetActive(true);

    }

    public void RaceBtn()
    {
        Debug.Log("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh");
        Debug.Log(nowIndex);
        ConnectingScenes.numbCar = nowIndex;
        SceneManager.LoadScene("Game");
    }





}
