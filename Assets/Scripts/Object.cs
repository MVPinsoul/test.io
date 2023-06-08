using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (animator.enabled)
        {
            animator.enabled = false;
        }
        else
        {
            animator.enabled = true;
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
