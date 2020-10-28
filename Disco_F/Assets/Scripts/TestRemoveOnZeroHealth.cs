using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRemoveOnZeroHealth : MonoBehaviour
{
    BossHealthBar bossHealth;

    private void Start()
    {
        bossHealth = GetComponent<BossHealthBar>();
    }

    private void Update()
    {
        if (bossHealth.currentHealth <=  0)
        {
            Debug.Log("Try to die");
            Destroy(gameObject);
        }
    }
}
