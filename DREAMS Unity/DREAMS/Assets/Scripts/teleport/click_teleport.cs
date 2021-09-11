using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class click_teleport : MonoBehaviour
{
    public GameObject user;
    public GameObject target;
    public GameObject start;
    public Animator transition;
    public GameObject CurrentLight;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start:" + user.transform.position);
        Debug.Log("end:" + target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("click!!!!!!");
        transition.SetTrigger("screen_end");
        transition.SetTrigger("screen_continue");

        user.SetActive(false);
        user.transform.position = new Vector3(target.transform.position.x+2, target.transform.position.y-47, target.transform.position.z);

        user.SetActive(true); 
        transition.SetTrigger("screen_start");
        GameObject[] temp = start.GetComponent<lightcontrol>().teleportlights;
        foreach (GameObject obj in temp)
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

        CurrentLight.GetComponent<Renderer>().enabled = true;
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.GetComponent<Renderer>().enabled = true;
        }

    }
}
