using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicknessScript : MonoBehaviour
{
    public int viralStrength = -1;

    private void Start()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<NPCHealthState>() != null)
        {
            other.GetComponent<NPCHealthState>().Sickening(viralStrength);
        }
    }
}
