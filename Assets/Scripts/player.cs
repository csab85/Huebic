using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //Stats
    float speed = 0.01f;
    string color;
    string direction = "";
    Vector3 slide;

    float fix = 0.05f; //distance to go back and stop clipping on collision

    void Start()
    {
        
    }

    void Update()
    {
        //CHANGE DIRECTIONS
        if(direction == "")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                slide = new Vector3(0, speed, 0);
                direction = "up";
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                slide = new Vector3(0, -speed, 0);
                direction = "down";
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                slide = new Vector3(speed, 0, 0);
                direction = "right";
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                slide = new Vector3(-speed, 0, 0);
                direction = "left";
            }
        }

        transform.position += slide;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        slide = new Vector3(0, 0, 0);

        if(direction == "up")
        {
            transform.position += new Vector3(0, -fix, 0);
            direction = "";
        }

        if (direction == "down")
        {
            transform.position += new Vector3(0, fix, 0);
            direction = "";
        }

        if (direction == "right")
        {
            transform.position += new Vector3(-fix, 0, 0);
            direction = "";
        }

        if (direction == "left")
        {
            transform.position += new Vector3(fix, 0, 0);
            direction = "";
        }
    }
}
