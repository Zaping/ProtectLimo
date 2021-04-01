using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLane : MonoBehaviour
{
    public GameObject[] enemy;
    private int rand;

    private void Start()
    {
        rand = Random.Range(0, enemy.Length);
        Instantiate(enemy[rand], transform.position, Quaternion.Euler(0, 180, 0));
    }
}
