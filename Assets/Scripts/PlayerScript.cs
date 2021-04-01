using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private Vector3 targetPos;
    private float xAxisMove;
    private float speed;
    private float maxX;
    private float minX;
 
    void Start()
    {       
        targetPos = transform.position;
        speed = 5;
        maxX = 2.8f;
        minX = -1.4f;
        xAxisMove = .7f;
    }

    // Update is called once per frame
    void Update()
    {       
        transform.position = Vector3.MoveTowards(transform.position,targetPos,speed*Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.LeftArrow)&&transform.position.x>minX)
        {
            GoLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)&&transform.position.x<maxX)
        {
            GoRight();
        }
    }
   public void GoLeft()
    {
        if (transform.position.x > minX)
        {
            targetPos = new Vector3(transform.position.x - xAxisMove, transform.position.y, transform.position.z);
        }

    }
    public void GoRight()
    {
        if (transform.position.x < maxX)
        {
            targetPos = new Vector3(transform.position.x + xAxisMove, transform.position.y, transform.position.z);
        }
    }
}
