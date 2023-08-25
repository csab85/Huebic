using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changer : MonoBehaviour
{

    public Animator animator;
    GameObject bic;
    int waitingTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        bic = GameObject.Find("Bic");
        animator = bic.GetComponent<Animator>();
        waitingTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MonoBehaviour.print(waitingTime);
        if (bic.GetComponent<Animator>().GetBool("transform") == true && waitingTime >= 50)
        {
            bic.GetComponent<Animator>().SetBool("transform", false);
            MonoBehaviour.print("irrinho");
            waitingTime = 0;
        }

        if(waitingTime > 0)
        {
            waitingTime += 1;
        }
    }

    //functions
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Bic")
        {
            collider.tag = gameObject.tag;

            if(gameObject.tag == "purple")
            {
                collider.GetComponent<SpriteRenderer>().color = new Color(0.37f, 0, 1, 1);
                GetComponent<AudioSource>().Play();
                bic.GetComponent<Animator>().SetBool("transform", true);
                waitingTime = 1;
                
            }

            if (gameObject.tag == "yellow")
            {
                collider.GetComponent<SpriteRenderer>().color = new Color(1, 0.8f, 0, 1);
                GetComponent<AudioSource>().Play();
                bic.GetComponent<Animator>().SetBool("transform", true);
                waitingTime = 1;
            }

            if (gameObject.tag == "red")
            {
                collider.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0.3f, 1);
                GetComponent<AudioSource>().Play();
                bic.GetComponent<Animator>().SetBool("transform", true);
                waitingTime = 1;
            }
        }
    }
}
