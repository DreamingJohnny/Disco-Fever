using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 bossVelocity;
    private bool groundedBoss;
    private float bossSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        groundedBoss = controller.isGrounded;
        if (groundedBoss && bossVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        if (Input.GetButtonDown("Jump") && groundedBoss)
        {
            bossVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        bossVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(bossVelocity * Time.deltaTime);
    }
}