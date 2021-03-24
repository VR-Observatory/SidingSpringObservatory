﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCircle : MonoBehaviour
{
    [Header("Time")]
    [SerializeField]
    private float _dayLength = 0.5f; //30s
    [SerializeField]
    [Range(0f, 1f)]
    private float _timeOfDay;
    private float _timeScale = 100f;
    public bool pause;


    [Header("Sun Light")]
    [SerializeField]
    private Transform dailyRotation;
    [SerializeField]
    private Light sun;
    [SerializeField]
    private Gradient sunColor;
    private float intensity;
    [SerializeField]
    private float sunBaseIntensity = 1;
    [SerializeField]
    private float sunVariation = 1.5f;


    [Header("Moon Light")]
    [SerializeField]
    private Light moon;
    [SerializeField]
    private Gradient moonColor;
    [SerializeField]
    private float moonBaseIntensity;

    [Header("Skybox")]
    public MySkybox[] skyboxes;

    private MySkybox currentSkybox;

    public enum SkyboxName {
        EARLYMORNING,
        MORNING,
        AFTERNOON,
        SUNSET,
        NIGHT,
        MIDNIGHT
    }
    [System.Serializable]
    public struct MySkybox {
        public string name;
        public Material skybox;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!pause)
        {
            UpdataTimeScale();
            UpdateTime();
        }
        AdjustSun();
        SunIntensity();
        AdjustMoon();
    }

    // change the real time to the game time
    private void UpdataTimeScale()
    {
        _timeScale = 24 / (_dayLength / 60);
    }

    private void UpdateTime()
    {
        _timeOfDay += Time.deltaTime * _timeScale / 86400;
        if (_timeOfDay > 1)
        {
            _timeOfDay -= 1;
        }
        if (_timeOfDay > 0 && _timeOfDay < 0.27)
        {
            currentSkybox = skyboxes[4]; // midnight
        }
        else if (_timeOfDay < 0.4)
        {
            currentSkybox = skyboxes[0]; // earlymorning
        }
        else if (_timeOfDay < 0.6)
        {
            currentSkybox = skyboxes[1]; // morning, noon
        }
        else if (_timeOfDay < 0.70)
        {
            currentSkybox = skyboxes[2]; // afternoon
        }
        else {
            currentSkybox = skyboxes[3]; // night
        }
        RenderSettings.skybox = new Material(currentSkybox.skybox);

    }



    private void AdjustSun()
    {
        float angle = _timeOfDay * 360f;
        dailyRotation.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, angle));
        // adjust color
        sun.color = sunColor.Evaluate(intensity);
    }

    private void SunIntensity()
    {
        intensity = Vector3.Dot(sun.transform.forward, Vector3.down);
        intensity = Mathf.Clamp01(intensity);

        sun.intensity = intensity * sunVariation + sunBaseIntensity;
    }

    private void AdjustMoon()
    {
        moon.color = moonColor.Evaluate(1 - intensity);
        moon.intensity = (1 - intensity) * moonBaseIntensity + 0.05f;
    }
}
