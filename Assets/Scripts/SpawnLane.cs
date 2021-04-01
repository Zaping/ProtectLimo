using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLane : MonoBehaviour
{
    public GameObject enemy;

    private void Start()
    {
        Instantiate(enemy, transform.position, Quaternion.Euler(0, 180, 0));
    }
}
