using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
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
}
