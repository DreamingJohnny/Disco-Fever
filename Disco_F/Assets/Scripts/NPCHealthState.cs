using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHealthState : MonoBehaviour
{
    //Logic operators for npc health and what state they are in
    public float npcHealth;
    public float npcMaxHealth = 100;
    public float npcFeverThreshold = 10;
    public float npcCuredThreshold = 90;

    //Enum to check state if npc is cured, neutral or feverish
    enum npcCuredOrFeverish
    {
        isCured,
        isFeverish,
        isNeutral
    }
    npcCuredOrFeverish npcHealthState;

    //Gives each npc their own physical body that will affect others.
    SicknessAura contagiousArea;

    void Start()
    {
        npcHealthState = npcCuredOrFeverish.isNeutral;

        npcHealth = npcMaxHealth * 0.5f;

        contagiousArea = new SicknessAura();
        
        //GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //sphere.transform.position = new Vector3(0, 0, 0);

    }

    void Update()
    {
        if (npcHealthState != npcCuredOrFeverish.isCured)
        {
            NPCCheckHealth();
            //Need to increase their sickness aura here? Will boss also have sickness aura true?
        }
        //else
        //{
            //if the NPC is cured, their aura needs to disappear,

            //contagiousArea = 
        //}
    }

    public void NPCCheckHealth()
    {

        if (npcHealth > npcCuredThreshold)
        {
            npcHealthState = npcCuredOrFeverish.isCured;
        }
        else if (npcHealth > npcFeverThreshold)
        {
            npcHealthState = npcCuredOrFeverish.isNeutral;
        }
        else if (npcHealth < npcFeverThreshold)
        {
            npcHealthState = npcCuredOrFeverish.isFeverish;
        }
    }

    public void NPCSickens(float auraStrength)
    {
        /*The NPC health will only be affected if it is between this span,
        This essentially means that an NPC will be "innoculated" if their health ever is more than 90
        It also means that they cannot become "more sick" once their health has reached 0*/
        if (npcHealth > 0 && npcHealthState != npcCuredOrFeverish.isFeverish)
        {
            npcHealth -= auraStrength * Time.deltaTime;
        }
    }

}

