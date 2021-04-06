using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelescopeController : MonoBehaviour
{
    public GameObject midpart_connection, toppart_connection;
    public float midpart_minimum_angle, midpart_maximum_angle, toppart_minimum_angle, toppart_maximum_angle;
    public int rotation_speed;
    private float midpart_default_angle, toppart_default_angle;

    // Start is called before the first frame update
    void Start()
    {
        midpart_default_angle = 90f;
        toppart_default_angle = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        print(toppart_default_angle);
    }

    private void Move() {

        // Button A/B for rotating middle part
        if (Input.GetButton("Fire1") && midpart_default_angle <= midpart_maximum_angle)
        {
            midpart_connection.transform.Rotate(Vector3.left * Time.deltaTime * rotation_speed);
            midpart_default_angle += Time.deltaTime * rotation_speed;
        }
        else if (Input.GetButton("Fire2") && midpart_default_angle >= midpart_minimum_angle) {
            midpart_connection.transform.Rotate(Vector3.right * Time.deltaTime * rotation_speed);
            midpart_default_angle -= Time.deltaTime * rotation_speed;
        }

        // Button X/Y for rotating top part
        if (Input.GetButton("Fire3") && toppart_default_angle <= toppart_maximum_angle)
        {
            toppart_connection.transform.Rotate(Vector3.up * Time.deltaTime * rotation_speed);
            toppart_default_angle += Time.deltaTime * rotation_speed;
        }
        else if (Input.GetButton("Jump") && toppart_default_angle >= toppart_minimum_angle)
        {
            toppart_connection.transform.Rotate(Vector3.down * Time.deltaTime * rotation_speed);
            toppart_default_angle -= Time.deltaTime * rotation_speed;
        }
    }
}
