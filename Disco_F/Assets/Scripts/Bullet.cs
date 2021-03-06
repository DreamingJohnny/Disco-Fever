﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage = 10;

    int randomNumber;
    public Sprite[] spritePicture;
 
    void Start()
    {
        randomNumber = Random.Range(0, spritePicture.Length);
        GetComponent<SpriteRenderer>().sprite = spritePicture[randomNumber];
    }

    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            Debug.Log("Trying to do damage");
            if (other.gameObject.GetComponent<BossHealthBar>() != null)
            {
                other.gameObject.GetComponent<BossHealthBar>().currentHealth -= bulletDamage;
            }
            else if (other.gameObject.GetComponent<NPCHealthState>() != null)
            {
                other.gameObject.GetComponent<NPCHealthState>().TakeDamage(bulletDamage);
            }
        }
    }

}
