using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 movement = new Vector3();
    float moveDistance = 0.5f;

    RaycastHit2D hit;
    float minDistance = 0.25f;
    float currentDistance;
    bool blockedRight;
    bool blockedLeft;

    public float bulletSpeed;
    public GameObject bullet;
    Vector3 bulletDirection = new Vector3(-0.5f, 0.25f);
    AudioSource shotSound;


    void Start()
    {
        movement = GetComponent<Transform>().position;
        shotSound = GetComponent<AudioSource>();
    }


    void Update()
    {
        CheckIfCanMoveRight();
        CheckIfCanMoveLeft();

        float x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Horizontal"))
        {
            if(x > 0 && !blockedRight)
            {
                movement.x += moveDistance;
                movement.y += (moveDistance / 2);
            }
            else if(x < 0 && !blockedLeft)
            {
                movement.x -= moveDistance;
                movement.y -= (moveDistance / 2);
            }

            transform.position += movement;
        }

        else
            movement = new Vector3(0,0);

        //Fireing
        if (Input.GetButtonDown("Fire1"))
        {
            shotSound.Play();
            GameObject firedShot = Instantiate(bullet, transform.position, transform.rotation);
            firedShot.GetComponent<Rigidbody2D>().velocity = bulletDirection * bulletSpeed;
        }
    }

    void CheckIfCanMoveRight()
    {
        Vector3 right = transform.TransformDirection(Vector3.right) * minDistance;
        Debug.DrawRay(transform.position, right, Color.red);

        if (Physics2D.Raycast(transform.position, (right), minDistance))
        {
            currentDistance = hit.distance;
            if (currentDistance < minDistance)
            {
                blockedRight = true;
            }
        }
        else
        {
            blockedRight = false;
        }
    }

    void CheckIfCanMoveLeft()
    {
        Vector3 left = transform.TransformDirection(Vector3.right) * -minDistance;
        Debug.DrawRay(transform.position, left, Color.green);

        if (Physics2D.Raycast(transform.position, (left), minDistance))
        {
            currentDistance = hit.distance;
            if (currentDistance < minDistance)
            {
                blockedLeft = true;
            }
        }
        else
        {
            blockedLeft = false;
        }
    }
}
