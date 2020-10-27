using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 movement = new Vector3();
    public float moveDistance = 0.5f;

    void Start()
    {
        movement = GetComponent<Transform>().position;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Horizontal"))
        {
            Debug.Log("Pressed the horizontal key");
            if(x > 0)
            {
                movement.x += moveDistance;
                movement.y += (moveDistance / 2);
            }
            else if(x < 0)
            {
                movement.x -= moveDistance;
                movement.y -= (moveDistance / 2);
            }

            transform.position += movement;
        }

        else
            movement = new Vector3(0,0);
        

    }
}
