using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public bool timerIsRunning;

    public delegate void onEndDelegate();
    public onEndDelegate onEndCallback;

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else if(timerIsRunning)
        {
            timeLeft = 0;
            timerIsRunning = false;
            onEndCallback?.Invoke();
        }

    }
    public void SetTime(float time)
    {
        timeLeft = time;
        timerIsRunning = true;
    }
    public void StopTimer()
    {
        timeLeft = 0;
        timerIsRunning = false;
    }
    public bool IsRunning()
    {
        return timerIsRunning;
    }
    public void OnEndMethod(onEndDelegate callback)
    {
        onEndCallback = callback;
    }

}
