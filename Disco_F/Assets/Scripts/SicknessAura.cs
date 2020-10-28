using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicknessAura : MonoBehaviour
{
    public float auraStrength = -1;

    private NPCHealthState healthScript;

    void Start()
    {
        healthScript = GetComponent<NPCHealthState>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<NPCHealthState>() != null)
        {
            other.GetComponent<NPCHealthState>().NPCSickens(auraStrength);
        }
    }
}
