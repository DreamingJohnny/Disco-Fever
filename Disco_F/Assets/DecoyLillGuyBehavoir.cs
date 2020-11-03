using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyLillGuyBehavoir : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetTrigger("Hit");
    }
}
