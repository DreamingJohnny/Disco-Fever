using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShooting : MonoBehaviour
{
    public float enemyBulletDamage = 5f;
    public float enemyBulletSpeed = 5f;
    public float timeBetweenEnemyShots = 1000;
    public float timeSinceEnemyShot = 0;

    public GameObject enemyBullet;
    Vector3 enemyBulletDirection = new Vector3(0.25f, -0.125f);

    void Update()
    {
        if (GetComponent<NPCHealthState>().npcCurrentState == NPCHealthState.npcState.isFeverish)
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
        }
    }
}