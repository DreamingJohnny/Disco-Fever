using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    bool shouldMove;
    bool hitWall;

    Vector3 npcMovement = new Vector3();
    int randomDirection;

    float npcMoveDistance = 0.5f;

    void Start()
    {
        npcMovement = GetComponent<Transform>().position;
        randomDirection = Random.Range(0, 2);
    }

    void Update()
    {
        shouldMove = GetComponent<NPCHealthState>().CheckIfCured();

        if(shouldMove && hitWall == false)
        {       
            npcMoves();
        }
    }
    void npcMoves()
    {

        if (randomDirection == 0)
        {
            npcMovement.x -= npcMoveDistance;
            npcMovement.y -= npcMoveDistance / 2;
        }
        else if (randomDirection == 1)
        {
            npcMovement.x += npcMoveDistance;
            npcMovement.y += npcMoveDistance / 2;
        }

        transform.position += npcMovement * 0.0001f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "InvisWall")
        {
            hitWall = true;
        }
    }


}