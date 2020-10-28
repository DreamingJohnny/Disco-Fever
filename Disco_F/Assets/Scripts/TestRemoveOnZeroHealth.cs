using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRemoveOnZeroHealth : MonoBehaviour
{
    BossHealthBar bossHealth;

    NPCHealthState npcHealthState;

    private void Start()
    {
        if (GetComponent<NPCHealthState>() != null)
        {
            npcHealthState = GetComponent<NPCHealthState>();
        }
        else if (GetComponent<BossHealthBar>() != null)
        {
            bossHealth = GetComponent<BossHealthBar>();
        }
    }

    private void Update()
    {
        if(npcHealthState.npcHealth <= 0)
        {
            Debug.Log("Try to die");
            Destroy(gameObject);
        }
        /*else if (bossHealth.currentHealth <=  0)
        {
            Debug.Log("Try to die");
            Destroy(gameObject);
        }*/
    }
}
