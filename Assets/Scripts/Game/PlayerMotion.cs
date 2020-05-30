using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMotion : MonoBehaviour
{



    Rigidbody2D rb;
    float speedForce = 30f;
    float torqueForce = -20f;
    float drift = 5.9f;

    //public Button left;
    
    int direction = 0;

   // GameObject player;

    void Start()

    {
        switch (ConnectingScenes.levelHard)
        {
            case 1:
                speedForce = 20f;
                break;
            case 2:
                speedForce = 45f;
                break;
            case 3:
                speedForce = 70f;
                break;

        }

        Debug.Log("STARTMOTION");

        rb = GetComponent<Rigidbody2D>();


    }

    public void LeftDown()
    {
        direction = -1;
      
    }

    public void RightDown()
    {
        direction = 1;
      
    }

    public void LeftUp()
    {
        direction = 0;
        
    }

    public void RightUp()
    {
        direction = 0;
    } 




    void FixedUpdate()
    {
        
        rb.velocity = forwardVelocity();
        
        rb.AddForce(transform.up* speedForce);

        rb.AddTorque(direction*torqueForce);
        
    }



    Vector2 forwardVelocity()
    {
        return transform.up * Vector2.Dot(GetComponent<Rigidbody2D>().velocity, transform.up);
    }

    Vector2 rightVelocity()
    {
        return transform.up * Vector2.Dot(GetComponent<Rigidbody2D>().velocity, transform.up);
    }


    
}
