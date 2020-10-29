using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    bool shouldMove;

    Vector3 npcMovement = new Vector3();

    float npcMoveDistance = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        npcMovement = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        shouldMove = GetComponent<NPCHealthState>().CheckIfCured();

        if(shouldMove)
        {
            npcMoves();

            Debug.Log("Is bustin those phat movezzz");
        }
    }
    void npcMoves()
    {
        npcMovement.x -= npcMoveDistance;
        npcMovement.y -= npcMoveDistance / 2;

        transform.position += npcMovement * 0.00001f;
    }
}
