using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicknessAura : MonoBehaviour
{
    public float auraStrength = 1.5f;
 
    public Vector3 auraGrowth = new Vector3(0.1f, 0.1f, 0.1f);

    void Start()
    {

    }

    private void Update()
    {
        AuraExpanding();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<NPCHealthState>() != null)
        {
            other.GetComponent<NPCHealthState>().NPCSickens(auraStrength);
        }
    }

    private void AuraExpanding()
    {
        this.transform.localScale += auraGrowth * Time.deltaTime;
    }
}
