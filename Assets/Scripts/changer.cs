using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Player")
        {
            collider.tag = gameObject.tag;

            if(gameObject.tag == "purple")
            {
                collider.GetComponent<SpriteRenderer>().color = new Color(0.37f, 0, 1, 1);
            }

            if (gameObject.tag == "yellow")
            {
                collider.GetComponent<SpriteRenderer>().color = new Color(1, 0.8f, 0, 1);
            }

            if (gameObject.tag == "red")
            {
                collider.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0.3f, 1);
            }
        }
    }
}
