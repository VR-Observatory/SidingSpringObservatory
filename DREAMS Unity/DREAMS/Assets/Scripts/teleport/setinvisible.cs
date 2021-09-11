using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setinvisible : MonoBehaviour
{
    public GameObject currentlight;


    // Start is called before the first frame update
    void Start()
    {
        currentlight.GetComponent<Renderer>().enabled = false;
        for (int i = 0; i < transform.childCount; i++)
        {
           transform.GetChild(i).gameObject.GetComponent<Renderer>().enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
