using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    Rigidbody2D rb;
    public Text score;

    
    //GameObject box;

    float randomX = 240;
    float randomY = 180;

    int score_box = 0;
   
    //    Quaternion quaternion = Quaternion.Euler(new Vector3(0, 0, 0));


    Vector3 getRandomPosition()
    {
        return new Vector3(Random.Range(-randomX, randomX), Random.Range(-randomY, randomY), 0);
    }


    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        transform.position = getRandomPosition();

    }



    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            score_box++;
            //Debug.Log(score.text);
            transform.position = getRandomPosition();
            score.text = score_box + "  ";


        }

        if (collider.gameObject.tag == "texture")
        {
            transform.position = getRandomPosition();

        }


    }


}
