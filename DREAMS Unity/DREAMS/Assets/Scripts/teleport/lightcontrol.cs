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
                for (int i = 0; i < obj.transform.childCount; i++)
                {
                    obj.transform.GetChild(i).gameObject.GetComponent<Renderer>().enabled = true;
                }
                Vector3 tar = transform.position;
                tar.y = obj.transform.position.y;
                obj.transform.LookAt(tar);
                obj.transform.Rotate(0, 180, 0);
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
                for (int i = 0; i < obj.transform.childCount; i++)
                {
                    obj.transform.GetChild(i).gameObject.GetComponent<Renderer>().enabled = false;
                }
                obj.GetComponent<Renderer>().enabled = false;
            }
        }
    }
}
