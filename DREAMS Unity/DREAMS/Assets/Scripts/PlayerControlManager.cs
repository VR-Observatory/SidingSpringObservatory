using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlManager : MonoBehaviour
{
    public enum controlModes
    {
        PC,
        OVR,
        Auto
    }
    public bool isDisplayPerformanceStats = false;

    public controlModes controlMode;
    public GameObject pcPlayerController;
    public GameObject ovrPlayerController;
    public GameObject pcPerformanceStats;
    public GameObject ovrPerformanceStats;

    // Start is called before the first frame update
    void Start()
    {
        switch (controlMode)
        {
            case controlModes.PC:
                ActivateControlPC();
                break;
            case controlModes.OVR:
                ActivateControlOVR();
                break;
            default:
                if (OVRManager.isHmdPresent)
                    ActivateControlOVR();
                else
                    ActivateControlPC();
                break;
        }
    }

    void ActivateControlPC()
    {
        pcPlayerController.SetActive(true);
        ovrPlayerController.SetActive(false);

        pcPerformanceStats.SetActive(isDisplayPerformanceStats);
    }
    void ActivateControlOVR()
    {
        pcPlayerController.SetActive(false);
        ovrPlayerController.SetActive(true);

        ovrPerformanceStats.SetActive(isDisplayPerformanceStats);
    }
}
