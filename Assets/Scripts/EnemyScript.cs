using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int damage=1;
    public float speed;
    private void Update()
    {
        transform.Translate(Vector3.forward * speed*Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Health>().health -= damage;
            Destroy(gameObject);
        }
    }
}
