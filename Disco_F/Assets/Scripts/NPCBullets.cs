using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBullets : MonoBehaviour
{
    public int bulletDamage = 5;
        
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Enemy trying to do damage");
            
            other.gameObject.GetComponent<NPCHealthState>().TakeDamage(bulletDamage);
        }
    }
}