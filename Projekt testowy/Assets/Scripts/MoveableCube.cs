using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableCube : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;

    public int speed;

    public bool isMovingLeft = true;


    // Update is called once per frame
    void Update()
    {
        if (isMovingLeft)
        {

            transform.Translate(-1 * Time.deltaTime * speed, 0, 0);
            if (transform.position.x < endPoint.position.x)
            {
                isMovingLeft = false;
            }
        }
        else
        {
            transform.Translate(1 * Time.deltaTime * speed, 0, 0);
            if (transform.position.x > startPoint.position.x)
            {
                isMovingLeft = true;
            }
        }

        
         
    }
    
}