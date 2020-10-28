using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHealthState : MonoBehaviour
{
    public float npcHealth;
    public float npcMaxHealth = 100;
    public float npcFeverThreshold = 10;
    public float npcCuredThreshold = 90;
    
    bool isFeverish = false;
    bool isCured = false;

    void Start()
    {
        npcHealth = npcMaxHealth * 0.5f;
    }


    public void NPCSickens(float auraStrength)
    {
        /*The NPC health will only be affected if it is between this span,
        This essentially means that an NPC will be "innoculated" if their health ever is more than 90
        It also means that they cannot become "more sick" once their health has reached 0*/
        if (npcHealth > 0 && !isCured)
        {
            npcHealth -= auraStrength;
        }
    }

    public void NPCCheckHealth()
    {
        if (!isCured)
        {
            if (npcHealth > npcCuredThreshold)
            {
                isCured = true;
                isFeverish = false;
            }
            else if (npcHealth > npcFeverThreshold)
            {
                isFeverish = false;
            }
            else if (npcHealth < npcFeverThreshold)
            {
                isFeverish = true;
            }
        }
    }
}

