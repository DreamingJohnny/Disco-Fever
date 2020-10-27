using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRendererOnPlay : MonoBehaviour
{
    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.enabled = false;
    }

 
}
