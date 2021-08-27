using UnityEngine;

public class TelescopeController : MonoBehaviour
{
    // mobile controls
    // TODO find simpler solution, input manager?
    public Joystick telescopeSlider1;
    public Joystick telescopeSlider2;
    public float sliderThreshold = 0.5f;

    public GameObject playerController; // needed to get input mode

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
        if (playerController.GetComponent<PlayerControlManager>().controlMode.Equals(PlayerControlManager.controlModes.AndroidMobile))
            MoveMobile();
        else
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
    private void MoveMobile()
    {

        // Button A/B for rotating middle part
        if (telescopeSlider1.Vertical > sliderThreshold && midpartDefaultAngle <= midpartMaximumAngle)
        {
            midpartConnection.transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);
            midpartDefaultAngle += Time.deltaTime * rotationSpeed;
        }
        else if (telescopeSlider1.Vertical < -sliderThreshold && midpartDefaultAngle >= midpartMinimumAngle)
        {
            midpartConnection.transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);
            midpartDefaultAngle -= Time.deltaTime * rotationSpeed;
        }

        // Button X/Y for rotating top part
        if (telescopeSlider2.Vertical > sliderThreshold && toppartDefaultAngle <= toppartMaximumAngle)
        {
            toppartConnection.transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
            toppartDefaultAngle += Time.deltaTime * rotationSpeed;
        }
        else if (telescopeSlider2.Vertical < -sliderThreshold && toppartDefaultAngle >= toppartMinimumAngle)
        {
            toppartConnection.transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);
            toppartDefaultAngle -= Time.deltaTime * rotationSpeed;
        }
    }
}
