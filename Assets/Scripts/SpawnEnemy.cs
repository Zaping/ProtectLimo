using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemies;
    private float spawnTimer;
    public float startTime;
    public float decreaseTime;
    public float minTime;
    void Update()
    {
        if (spawnTimer <= 0)
        {
            int rand = Random.Range(0, enemies.Length);
            Instantiate(enemies[rand], transform.position,Quaternion.Euler(0,180,0));
            spawnTimer = startTime;
            if(startTime>minTime)
                startTime -= decreaseTime;
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
    }
}
