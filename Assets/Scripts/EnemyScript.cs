using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject player;
    public int health;
    public bool detect;
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
        if (detect)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, playerTransform.position, 0.01f);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            detect = true;
            

        }

    }
}


