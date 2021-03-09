using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonControlPC : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 10f;

    Vector3 velocity;

    public GameObject roof;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Y_axis");

        Vector3 move = transform.right * x + transform.up * y + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

    }

    void RoofControl() {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (roof.GetComponent<Animator>().GetBool("Roof") == true)
                roof.GetComponent<Animator>().SetBool("Roof", false);
            else
                roof.GetComponent<Animator>().SetBool("Roof", true);
        }

    }
}
