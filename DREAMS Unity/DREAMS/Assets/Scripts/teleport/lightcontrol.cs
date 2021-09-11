using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontrol : MonoBehaviour
{
    public GameObject currentLight;
    public GameObject[] teleportlights = new GameObject[3];



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Cursor.visible = true;
        foreach (GameObject obj in teleportlights)
        {
            if (obj)
            {
                obj.GetComponent<Renderer>().enabled = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Cursor.visible = false;

        foreach (GameObject obj in teleportlights)
        {
            if (obj)
            {
                obj.GetComponent<Renderer>().enabled = false;
            }
        }
    }
}
