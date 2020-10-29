using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBullets : MonoBehaviour
{
    public int enemyBulletDamage = 5;
        
    public Sprite spritePicture;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = spritePicture;
    }

    void Update()
    {
       
        /*if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }*/
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Enemy trying to do damage");
            
            other.gameObject.GetComponent<PlayerHealthBar>().TakeDamage(enemyBulletDamage);
        }
    }
}