using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHealthState : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;

    void Start()
    {
        health = maxHealth;
    }
}

