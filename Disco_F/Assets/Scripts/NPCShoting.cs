/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShoting : MonoBehaviour
{
    public int enemyBulletDamage = 5;
    public float bulletSpeed;

    /*  fix later
    public Sprite[] spritePicture;
    AudioSource shotSound;
    shotSound = GetComponent<AudioSource>();

    
    public GameObject bullet;
    Vector3 bulletDirection = new Vector3(-0.5f, 0.25f);

    /*
     * So, I need to spawn bullets
     * Then I need the bullets to move in the right direction
     * Then I need the bullet to damage player
     * Then I need the enemy that 
     * 
    //Firing
        if (Input.GetButtonDown("Fire1"))
        {
            shotSound.Play();
            GameObject firedShot = Instantiate(bullet, transform.position, transform.rotation);
    firedShot.GetComponent<Rigidbody2D>().velocity = bulletDirection* bulletSpeed;
}

// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Enemy is trying to do damage");
           
            other.gameObject.GetComponent<PlayerHealthBar>().TakeDamage(enemyBulletDamage);
        }
    }
}
}
*/
