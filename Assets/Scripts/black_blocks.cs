using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black_blocks : MonoBehaviour
{
    GameObject bic;
    float minusX = 0.001f;
    float minusY = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        bic = GameObject.Find("Bic");
    }

    // Update is called once per frame
    void Update()
    {
        if(bic.tag == "purple")
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

        if(gameObject.tag == "diferentao" && bic.tag == "purple")
        {
            gameObject.transform.position += new Vector3(0.005f, 0, 0);
        }
    }
}
