using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float BaseSpeed;
    public float DashSpeed;

    private Vector3 vector;
    private Vector3 dashVector;

    public float dashTime;
    private Timer dashTimer;

    private void Start()
    {
        dashTimer = gameObject.AddComponent<Timer>();//make timer
    }
    void Update()
    {
        vector=new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);//get directional input

        if (Input.GetKeyDown("space"))//if press spacebar then start dash
        {
            dashVector = vector;//save vector player was moving in when they dashed
            dashTimer.setTime(dashTime);
        }
        if (dashTimer!=null && dashTimer.timerIsRunning())//if timer is running then move at DashSpeed
        {
            vector = dashVector;
            vector *= DashSpeed;
        }
        else vector *= BaseSpeed;//if not dashing then move at BaseSpeed

        this.gameObject.transform.position += vector * Time.deltaTime;//move player
    }


}