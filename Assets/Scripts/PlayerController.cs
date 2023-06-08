using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5;
    private Animator animator;
    private Vector2 direction;
    private Rigidbody2D rb;
    private float x = 0;
    private float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
       
    }
    void View(float x, float y)
    {
        if (x > 0)
        {
            animator.SetInteger("View", 3);
        }
        else if (x < 0)
        {
            animator.SetInteger("View", 4);
        }
        else if (y > 0)
        {
            animator.SetInteger("View", 2);
        }
        else
        {
            animator.SetInteger("View", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);
       
        if (x != direction.x || y != direction.y) { 
            View(x, y);
            x = direction.x;
            y = direction.y;
        }
        
        rb.MovePosition(rb.position + direction*speed*Time.fixedDeltaTime);
    }
}
