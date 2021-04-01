using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnEnemies : MonoBehaviour
{
    public float destroyTime;
    void Start()
    {
        Destroy(gameObject,destroyTime);
    }

}
