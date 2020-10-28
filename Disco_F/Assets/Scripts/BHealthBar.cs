using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BHealthBar : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public BHealthBar BhealthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        BhealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        BhealthBar.SetHealth(currentHealth);
    }
}

