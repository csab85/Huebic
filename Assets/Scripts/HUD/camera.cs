using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public bool change;

    GameObject bic;
    float growX = 0.5f;
    float growY = 0.5f;
    float growSize = 1;
    bool changing = true;

    // Start is called before the first frame update
    void Start()
    {
        bic = GameObject.Find("Bic");
    }

    // Update is called once per frame
    void Update()
    {
        if(changing == true && gameObject.tag == "changing")
        {
            gameObject.transform.position += new Vector3(growX, growY, 0) * Time.deltaTime;
            gameObject.GetComponent<Camera>().orthographicSize += growSize * Time.deltaTime;
        }

        Vector3 posit = gameObject.transform.position;
        float size = gameObject.GetComponent<Camera>().orthographicSize;

        if (posit.x >= 6)
        {
            growX = 0;
        }

        if (posit.y >= 10.5)
        {
            growY = 0;
        }

        if (size >= 9.391539)
        {
            growSize = 0;
        }

        if(growX == 0 && growY == 0 && growSize == 0)
        {
            changing = false;
        }
    }
}
