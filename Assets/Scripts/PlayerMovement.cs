using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Timer timer;

    public float BaseSpeed;
    public float DashSpeed;

    private Vector3 vector;
    private Vector3 dashVector;

    public float dashTime;
    private Timer dashTimer;
    public float dashRegenTime;
    private Timer dashRegenTimer;
    public float BaseDashAmount;
    public float dashAmount;

    public float health;

    public float defense;

    public float atkPower;

    private void Start()
    {
        dashTimer = Instantiate(timer);
        dashTimer.OnEndMethod(OnDashEnd);
        dashRegenTimer = Instantiate(timer);
        dashRegenTimer.OnEndMethod(OnDashRegenEnd);

        dashAmount=BaseDashAmount;
    }
    void Update()
    {
        vector=new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);//get directional input
        vector.Normalize();

        if (Input.GetKeyDown(KeyCode.Space) && dashAmount > 0)//if press spacebar then start dash.
        {
            dashVector = vector;//save vector player was moving in when they dashed
            dashAmount -= 1;//lower dash amount when player dashes
            dashTimer.SetTime(dashTime);//start timer
            dashRegenTimer.StopTimer();//if you dash again stop timer
        }
        if (dashTimer.IsRunning())//if timer is running then move at DashSpeed
        {
            vector = dashVector;
            vector *= DashSpeed;//move at dash speed
        }
        else vector *= BaseSpeed;//if not dashing then move at BaseSpeed

        this.gameObject.transform.position += vector * Time.deltaTime;//move player
    }

    void OnDashEnd()
    {
        dashRegenTimer.SetTime(dashRegenTime);
    }
    void OnDashRegenEnd()
    {
        dashAmount = BaseDashAmount;
    }
}