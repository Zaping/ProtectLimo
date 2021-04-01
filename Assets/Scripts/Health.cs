using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health=1;

    protected virtual void Update()
    {
        if (health <= 0)
            Die();
    }
    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}
