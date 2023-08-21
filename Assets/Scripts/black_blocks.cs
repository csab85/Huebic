using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black_blocks : MonoBehaviour
{

    GameObject bic;
    GameObject cam;
    float minusX = 0.002f;
    float minusY = 0.002f;

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

        if(gameObject.tag == "diferentao" && cam.tag == "changing")
        {
            gameObject.transform.position += new Vector3(0.01f, 0, 0);
        }

        if (gameObject.tag == "diferentaco" && cam.tag == "changing")
        {
            gameObject.transform.position += new Vector3(0, 0.01f, 0);
        }
    }
}
