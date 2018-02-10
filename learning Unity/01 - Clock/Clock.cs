using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

    public Transform hTransform, mTransform, sTransform;
    public bool continuous;

    const float degreesPerHour = 30f, degreesPerMinute = 6f, degreesPerSecond = 6f;

    void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        mTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinute, 0f);
        sTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond, 0f);
    }

    void UpdateDiscreate()
    {
        DateTime time = DateTime.Now;
        hTransform.localRotation = Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        mTransform.localRotation = Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        sTransform.localRotation = Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
    }

    // Use this for initialization
    void Start () {
        UpdateDiscreate();
	}

    private void Update()
    {
        if (continuous)
            UpdateContinuous();
        else
            UpdateDiscreate();
    }
}
