using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black_blocks : MonoBehaviour
{

    GameObject bic;
    GameObject cam;
    float minusX = 0.001f;
    float minusY = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        bic = GameObject.Find("Bic");
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if(cam.tag == "changing")
        {
            gameObject.transform.localScale -= new Vector3(minusX, minusY, 0);
        }

        Vector3 size = gameObject.transform.localScale;

        if(size.x <= 0)
        {
            minusX = 0f;
        }

        if(size.y <= 0)
        {
            minusY = 0f;
        }

        if(size.x <= 0 && size.y <= 0)
        {
            Destroy(gameObject);
        }

        if(gameObject.tag == "right" && cam.tag == "changing")
        {
            gameObject.transform.position += new Vector3(2, 0, 0) * Time.deltaTime;
        }

        if (gameObject.tag == "left" && cam.tag == "changing")
        {
            gameObject.transform.position += new Vector3(-2, 0, 0) * Time.deltaTime;
        }

        if (gameObject.tag == "up" && cam.tag == "changing")
        {
            gameObject.transform.position += new Vector3(0, 2, 0) * Time.deltaTime;
        }

        if (gameObject.tag == "down" && cam.tag == "changing")
        {
            gameObject.transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
        }
    }
}
