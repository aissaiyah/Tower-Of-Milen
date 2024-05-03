using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float BaseSpeed;

    private Vector3 vector;
    // Update is called once per frame
    void Update()
    {
        vector=new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        this.gameObject.transform.position+=vector*BaseSpeed*Time.deltaTime;
    }
}