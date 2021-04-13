using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonControlPC : MonoBehaviour
{
    public CharacterController controller;

    public bool canFly = false;

    public float speed = 10f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public GameObject roof;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0 && !canFly)
            velocity.y = -2f;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Y_axis");

        Vector3 move = transform.right * x + transform.up * y + transform.forward * z;

        
        controller.Move(move * speed * Time.deltaTime);

        if (!canFly)
        {
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }    
}
