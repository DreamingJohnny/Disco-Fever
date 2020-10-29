using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShooting : MonoBehaviour
{
    public float enemyBulletDamage = 5f;
    public float enemyBulletSpeed = 5f;
    public float timeBetweenEnemyShots = 1000;
    public float timeSinceEnemyShot = 0;

    /*
    public Sprite spritePicture;
    AudioSource shotSound;
    shotSound = GetComponent<AudioSource>();
    */

    public GameObject enemyBullet;
    Vector3 enemyBulletDirection = new Vector3(0.25f, -0.125f);

    /*
     * then I need the enemy to decide to fire bullets.
     * Then I need the bullet to damage player
     * Then I need the enemy to decide when to shoot, so, probably having a ticker go up right?
     * And then I need them to be able to fire three bullets.
     */

    void Update()
    {
        if (timeSinceEnemyShot > timeBetweenEnemyShots)
        {
            //When firing
            GameObject npcFiredBullet = Instantiate(enemyBullet, transform.position, transform.rotation);
            npcFiredBullet.GetComponent<Rigidbody2D>().velocity = enemyBulletDirection * enemyBulletSpeed;

            timeSinceEnemyShot = 0;
        }
        else
        {
            timeSinceEnemyShot++;
        }

        /*if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
        */
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("Enemy is trying to do damage");
           
            //other.gameObject.GetComponent<PlayerHealthBar>().TakeDamage(enemyBulletDamage);
        }
    }
}