using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_star : MonoBehaviour
{
    public GameObject Crosshairs;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Crosshairs.GetComponent<DrawStar>().Crosshairs_visible = true;

    }
    private void OnTriggerExit(Collider other)
    {
        Crosshairs.GetComponent<DrawStar>().Crosshairs_visible = false;


    }
}
