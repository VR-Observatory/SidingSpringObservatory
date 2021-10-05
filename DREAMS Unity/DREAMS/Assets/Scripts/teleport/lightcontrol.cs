using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontrol : MonoBehaviour
{
    public GameObject currentLight;
    public GameObject[] teleportlights = new GameObject[3];
    public GameObject Crosshairs;
    public GameObject teleport_notice;
    public GameObject eventsys;

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
        //Debug.Log("enter");
        eventsys.GetComponent<click_control>().all_enable();

        teleport_notice.SetActive(true); // instructions should always be visible, even after first

        //Debug.Log("enter active");
        foreach (GameObject obj in teleportlights)
        {
            if (obj)
            {
                obj.SetActive(true);

                Vector3 tar = transform.position;
                tar.y = obj.transform.position.y;
                obj.transform.LookAt(tar);
                obj.transform.Rotate(0, 180, 0);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        eventsys.GetComponent<click_control>().all_disable();

        teleport_notice.SetActive(false);

        foreach (GameObject obj in teleportlights)
        {
            if (obj)
            {

                obj.SetActive(false);
            }
        }
    }
}
