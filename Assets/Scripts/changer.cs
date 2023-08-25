using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changer : MonoBehaviour
{

    public Animator animator;
    GameObject bic;
    GameObject biclone;
    int waitingTime = 1;
    string lastColor;

    // Start is called before the first frame update
    void Start()
    {
        bic = GameObject.Find("Bic");
        biclone = GameObject.Find("Biclone");
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
            biclone.tag = collider.tag;
            collider.tag = gameObject.tag;

            //change bic color

            if (gameObject.tag == "purple")
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

            //change biclone color

            if (biclone.tag == "purple")
            {
                biclone.GetComponent<SpriteRenderer>().color = new Color(0.37f, 0, 1, 1);
            }

            if (biclone.tag == "yellow")
            {
                biclone.GetComponent<SpriteRenderer>().color = new Color(1, 0.8f, 0, 1);
            }

            if (biclone.tag == "red")
            {
                biclone.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0.3f, 1);
            }

            if (biclone.tag == "Untagged")
            {
                biclone.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            }
        }
    }
}
