using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 movement = new Vector3();
    public float moveDistance = 0.5f;
    bool movingRight;
    RaycastHit2D hit;

    void Start()
    {
        movement = GetComponent<Transform>().position;

    }


    //Working to see if I can make a Raycast from player to the collider
    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics2D.Raycast(transform.position, -Vector3.up))
        {
            Debug.DrawLine(ray.origin, hit.point);
        }
    }
    void Update()
    {
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
    }
}
