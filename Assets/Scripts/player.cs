using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    GameObject cam;

    //Stats
    float speed0 = 7;
    string direction = "";
    Vector3 slide;

    //sound arrays
    public AudioClip[] sounds;

    //functions
    float fix(float value)
    {
        float roundValue = Mathf.Round(value);

        if(roundValue > value)
        {
            roundValue -= 0.5f;
            return roundValue;
        }

        if (roundValue < value)
        {
            roundValue += 0.5f;
            return roundValue;
        }

        return value;
    }

    void Stop() //make square stop dashing
    {
        slide = new Vector3(0, 0, 0);
        GetComponent<AudioSource>().clip = sounds[0];
        GetComponent<AudioSource>().Play(); 

        if (direction == "up")
        {
            Vector3 posit = transform.position;
            float positY = posit.y;
            float positX = posit.x;

            transform.position = new Vector3 (positX, fix(positY), 0);
        }

        if (direction == "down")
        {
            Vector3 posit = transform.position;
            float positY = posit.y;
            float positX = posit.x;

            transform.position = new Vector3 (positX, fix(positY), 0);
        }

        if (direction == "right")
        {
            Vector3 posit = transform.position;
            float positY = posit.y;
            float positX = posit.x;

            transform.position = new Vector3 (fix(positX), positY, 0);
        }

        if (direction == "left")
        {
            Vector3 posit = transform.position;
            float positY = posit.y;
            float positX = posit.x;

            transform.position = new Vector3 (fix(positX), positY, 0);
        }

        direction = "";
    }

    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    void Update()
    {
        //CHANGE DIRECTIONS
        if (direction == "")
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                slide = new Vector3(0, speed0, 0);
                direction = "up";
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                slide = new Vector3(0, -speed0, 0);
                direction = "down";
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                slide = new Vector3(speed0, 0, 0);
                direction = "right";
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                slide = new Vector3(-speed0, 0, 0);
                direction = "left";
            }
        }

        //move
        transform.position += slide * Time.deltaTime;

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
                cam.tag = "changing";
            }

            else
            {
                Stop();
            }
        }
    }
}


