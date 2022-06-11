﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFlyGlideController : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("flyGlide", true);
    }

    // Update is called once per frame
    void Update()
    {
        // if player teleports to dragon (or box collider solution)
        //      mount dragon
    }
}
