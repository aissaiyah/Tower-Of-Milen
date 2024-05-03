using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    public float distanceFromPlayer;

    void Update()
    {
        // Calculate the position of the mouse cursor in world space
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; // Ensure z position is at the same level as the player and circle

        // Calculate direction from player to mouse cursor
        Vector3 direction = mousePos - transform.parent.transform.position;
        direction.Normalize();

        // Calculate circle's position based on distance from the player
        Vector3 circlePos = transform.parent.transform.position + direction * distanceFromPlayer;

        // Move the circle to the calculated position
        transform.position = circlePos;

        // Rotate the circle to point towards the mouse cursor
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
