﻿using UnityEngine;

public class TelescopeController : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField]
    private GameObject midpartConnection;
    [SerializeField]
    private GameObject toppartConnection;
    [SerializeField]
    [Range(0f, 100f)]
    private int rotationSpeed;

    [Header("Midpart Rotation")]
    [SerializeField]
    [Range(-90f, 270f)]
    private float midpartMinimumAngle;
    [SerializeField]
    [Range(-90f, 270f)]
    private float midpartMaximumAngle;

    [Header("Toppart Rotation")]
    [SerializeField]
    [Range(-90f, 270f)]
    private float toppartMinimumAngle;
    [SerializeField]
    [Range(-90f, 270f)]
    private float toppartMaximumAngle;

    private float midpartDefaultAngle, toppartDefaultAngle;

    // Start is called before the first frame update
    void Start()
    {
        midpartDefaultAngle = 90f;
        toppartDefaultAngle = 90f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move() {

        // Button A/B for rotating middle part
        if (Input.GetButton("Telescope Mid Rotate Pos") && midpartDefaultAngle <= midpartMaximumAngle)
        {
            midpartConnection.transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);
            midpartDefaultAngle += Time.deltaTime * rotationSpeed;
        }
        else if (Input.GetButton("Telescope Mid Rotate Neg") && midpartDefaultAngle >= midpartMinimumAngle) {
            midpartConnection.transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);
            midpartDefaultAngle -= Time.deltaTime * rotationSpeed;
        }

        // Button X/Y for rotating top part
        if (Input.GetButton("Telescope Top Rotate Pos") && toppartDefaultAngle <= toppartMaximumAngle)
        {
            toppartConnection.transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
            toppartDefaultAngle += Time.deltaTime * rotationSpeed;
        }
        else if (Input.GetButton("Telescope Top Rotate Neg") && toppartDefaultAngle >= toppartMinimumAngle)
        {
            toppartConnection.transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);
            toppartDefaultAngle -= Time.deltaTime * rotationSpeed;
        }
    }
}