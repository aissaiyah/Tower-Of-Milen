using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject player;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        player = GameObject.FindGameObjectWithTag("Player");


        playerTransform = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(this.transform.position, playerTransform.position, 0.01f);
    }
}
