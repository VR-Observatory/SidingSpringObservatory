using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public int avgFrameRate;
    public GameObject Text;
    public Material skybox1, skybox2;

    public void Update()
    {
        float current = 0;
        current = (int)(1f / Time.unscaledDeltaTime);
        avgFrameRate = (int)current;
        Text.GetComponent<TextMesh>().text = avgFrameRate.ToString() + " FPS";
        
    }
}
