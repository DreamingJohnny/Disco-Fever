using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 movement = new Vector3();
    float moveDistance = 0.5f;
    bool movingRight;



    void Start()
    {
        movement = GetComponent<Transform>().position;
    }



    void Update()
    {
        //RaycastHit2D hit;
        //float theDistance = 0.25;

        //Vector3 right = transform.TransformDirection(Vector3.right) * 0.25f;
        
        
        float x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Horizontal"))
        {
            if(x > 0)
            {
                movingRight = true;
                movement.x += moveDistance;
                movement.y += (moveDistance / 2);
            }
            else if(x < 0)
            {
                movingRight = false;
                movement.x -= moveDistance;
                movement.y -= (moveDistance / 2);
            }

            transform.position += movement;
        }

        else
            movement = new Vector3(0,0);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (movingRight)
        {
            Debug.Log("Collided with something to the right");
            movement.x -= moveDistance;
            movement.y -= (moveDistance / 2);
            transform.position += movement;
        }
        else
        {
            Debug.Log("Collided with something to the left");
            movement.x += moveDistance;
            movement.y += (moveDistance / 2);
            transform.position += movement;
        }
        movement = new Vector3(0, 0);
    }
}
