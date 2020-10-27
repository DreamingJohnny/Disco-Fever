using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicknessScript : MonoBehaviour
{
    public int viralStrength = -1;

    private NPCHealthState healthScript;

    void Start()
    {
        healthScript = GetComponent<NPCHealthState>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<NPCHealthState>() != null)
        {
            other.GetComponent<NPCHealthState>().Sickening(viralStrength);
        }
    }

    public void Sickening(int viralStrength)
    {
        healthScript.health -= viralStrength;
    }
}
