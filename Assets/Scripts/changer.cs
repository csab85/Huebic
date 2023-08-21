using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changer : MonoBehaviour
{

    GameObject bic;

    // Start is called before the first frame update
    void Start()
    {
        bic = GameObject.Find("Bic");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Bic")
        {
            collider.tag = gameObject.tag;

            if(gameObject.tag == "purple")
            {
                collider.GetComponent<SpriteRenderer>().color = new Color(0.37f, 0, 1, 1);
                GetComponent<AudioSource>().Play();
            }

            if (gameObject.tag == "yellow")
            {
                collider.GetComponent<SpriteRenderer>().color = new Color(1, 0.8f, 0, 1);
                GetComponent<AudioSource>().Play();
            }

            if (gameObject.tag == "red")
            {
                collider.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0.3f, 1);
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
