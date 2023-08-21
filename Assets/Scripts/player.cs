using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //Stats
    float speed = 0.033f;
    string color;
    string direction = "";
    Vector3 slide;

    float fix = 0.001f; //distance to go back and stop clipping on collision

    //sound arrays
    public AudioClip[] sounds;

    //functions
    void Stop() //make square stop dashing
    {
        slide = new Vector3(0, 0, 0);
        GetComponent<AudioSource>().clip = sounds[0];
        GetComponent<AudioSource>().Play(); 

        if (direction == "up")
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

        //move
        transform.position += slide;

        //change colors

    }

    //stop or go through on walls
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.GetComponent<Collider2D>().isTrigger != true)
        {
            if(collider.gameObject.tag == gameObject.tag)
            {
                GetComponent<AudioSource>().clip = sounds[1];
                GetComponent<AudioSource>().Play();
            }

            else
            {
                Stop();
            }
        }
    }
}


