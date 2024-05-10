using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esp : MonoBehaviour
{
    public float worldPosX;
    public float worldPosY;
    public GameObject Enemy;
    public Vector3 position;
    public float enemyCount;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


        while(enemyCount < 15)
        {
            worldPosX = Random.Range(-25, 25);
            worldPosY = Random.Range(-25, 25);
            position = new Vector3(worldPosX, worldPosY, 0);
            Instantiate(Enemy, position, Quaternion.identity);
            enemyCount++;
        }
        


    }
}
