using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Animator animator;

    public bool block;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (block)
        {
            animator.SetTrigger("TriggerBlock");
        }

        block = false;
    }
}
