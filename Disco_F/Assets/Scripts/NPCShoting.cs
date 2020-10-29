using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShoting : MonoBehaviour
{
    public int enemyBulletDamage = 5;

    public Sprite[] spritePicture;


    public float bulletSpeed;
    public GameObject bullet;
    Vector3 bulletDirection = new Vector3(-0.5f, 0.25f);
    AudioSource shotSound;


    shotSound = GetComponent<AudioSource>();


        //Fireing
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
