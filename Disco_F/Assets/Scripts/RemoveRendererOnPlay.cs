using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRendererOnPlay : MonoBehaviour
{
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.enabled = false;
    }
}