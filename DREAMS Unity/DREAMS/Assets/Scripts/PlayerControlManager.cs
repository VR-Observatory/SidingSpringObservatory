using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlManager : MonoBehaviour
{
    public enum controlModes
    {
        PC,
        OVR,
        AndroidMobile,
        Auto
    }
    public bool isDisplayPerformanceStats = false;

    public controlModes controlMode;

    public GameObject pcPlayerController;
    public GameObject ovrPlayerController;
    public GameObject androidMobilePlayerController;

    public GameObject pcPerformanceStats;
    public GameObject ovrPerformanceStats;
    // public GameObject androidMobilePerformanceStats;

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
            case controlModes.AndroidMobile:
                ActivateControlAndroidMobile();
                break;
            default:
                if (OVRManager.isHmdPresent)
                    ActivateControlOVR();
                else if (Application.platform == RuntimePlatform.Android)
                    ActivateControlAndroidMobile();
                else
                    ActivateControlPC();
                break;
        }
    }

    void ActivateControlPC()
    {
        pcPlayerController.SetActive(true);
        ovrPlayerController.SetActive(false);
        androidMobilePlayerController.SetActive(false);

        pcPerformanceStats.SetActive(isDisplayPerformanceStats);
    }
    void ActivateControlOVR()
    {
        pcPlayerController.SetActive(false);
        ovrPlayerController.SetActive(true);
        androidMobilePlayerController.SetActive(false);

        ovrPerformanceStats.SetActive(isDisplayPerformanceStats);
    }
    void ActivateControlAndroidMobile()
    {
        pcPlayerController.SetActive(false);
        ovrPlayerController.SetActive(false);
        androidMobilePlayerController.SetActive(true);

        // androidMobilePerformanceStats.SetActive(isDisplayPerformanceStats);
    }
}
