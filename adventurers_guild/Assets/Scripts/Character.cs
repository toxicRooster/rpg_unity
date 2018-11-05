using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private float speed;

    protected Vector2 direction;

    // Characters Animator controller
    private Animator animator;


    // Use this for initialization
    protected virtual void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if(direction.x != 0 || direction.y != 0)
        {
            AnimateMovement(direction);
        }
        else
        {
            // change the animator layer back to idle
            animator.SetLayerWeight(animator.GetLayerIndex("WalkLayer"), 0);
        }
        
    }

    public void AnimateMovement(Vector2 direction)
    {
        // Set the weight of the animator layer to chnage to walk animation when moving
        animator.SetLayerWeight(animator.GetLayerIndex("WalkLayer"), 1);

        //Set the animator parameters to make the character face the correct way
        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }
}
