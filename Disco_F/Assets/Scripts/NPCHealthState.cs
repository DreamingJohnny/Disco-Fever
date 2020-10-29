using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHealthState : MonoBehaviour
{
    //Logic operators for npc health and what state they are in
    public float npcCurrentHealth;
    public float npcMaxHealth = 100;
    public float npcFeverThreshold = 10;
    public float npcCuredThreshold = 90;
    public GameObject sicknessArea;
    public bool auraFromStart;

    //Enum to check state if npc is cured, neutral or feverish
    public enum npcState
    {
        isCured,
        isFeverish,
        isNeutral
    }
    npcState npcCurrentState;

    void Start()
    {
        npcCurrentState = npcState.isNeutral;

        npcCurrentHealth = npcMaxHealth * 0.5f;

        sicknessArea.GetComponent<SicknessAura>().enabled = auraFromStart;
    }

    void Update()
    {
        if (npcCurrentState != npcState.isCured)
        {
            NPCCheckHealth();
            if (npcCurrentState == npcState.isFeverish)
            {
                sicknessArea.GetComponent<SicknessAura>().enabled = true;
            }
        }
        else 
        {
            sicknessArea.SetActive(false);
        }
    }

    public void NPCCheckHealth()
    {

        if (npcCurrentHealth > npcCuredThreshold)
        {
            npcCurrentState = npcState.isCured;
        }
        else if (npcCurrentHealth > npcFeverThreshold)
        {
            npcCurrentState = npcState.isNeutral;
        }
        else if (npcCurrentHealth < npcFeverThreshold)
        {
            npcCurrentState = npcState.isFeverish;
        }
    }

    public void NPCSickens(float auraStrength)
    {
        /*The NPC health will only be affected if it is between this span,
        This essentially means that an NPC will be "innoculated" if their health ever is more than 90
        It also means that they cannot become "more sick" once their health has reached 0*/
        if (npcCurrentHealth > 0 && npcCurrentState != npcState.isFeverish)
        {
            npcCurrentHealth -= auraStrength * Time.deltaTime;
        }
    }

    public void TakeDamage(int damage)
    {
        npcCurrentHealth += damage;
    }
    public bool CheckIfCured()
    {
        if (npcCurrentState != npcState.isCured)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

