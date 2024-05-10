using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float timeLeft;

    public Timer(float time)
    {
        timeLeft = time;
    }

    void Update()
    {
        if (timeLeft > 0) timeLeft -= Time.deltaTime;
        else timeLeft = 0;  //PlayerMovement.dashAmount += 2;
    }
    public void setTime(float time)
    {
        timeLeft=time;
    }
    public bool timerIsRunning()
    {
        if (timeLeft > 0) return true;
        else return false;
    }
}
