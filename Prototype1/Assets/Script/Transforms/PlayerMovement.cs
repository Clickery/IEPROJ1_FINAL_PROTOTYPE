using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0.0f;
    public Animator animator;
    public Rigidbody2D rb;

    private enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        NONE
    }

    private Direction xDir = Direction.NONE;
    private Direction yDir = Direction.NONE;

    Vector2 movement;
    Vector3 spMovement = new Vector3(0,0,0);

    // Update is called once per frame
    void Update()
    {
        this.InputListen();
        this.Move();

        animator.SetFloat("Horizontal", this.spMovement.x);
        animator.SetFloat("Vertical", this.spMovement.y);
        animator.SetFloat("Speed", this.spMovement.magnitude);

    }

    private void InputListen()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.yDir = Direction.UP;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.yDir = Direction.DOWN;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.xDir = Direction.LEFT;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.xDir = Direction.RIGHT;
        }

        if ((Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow)))
        {
            this.yDir = Direction.NONE;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {

            this.xDir = Direction.NONE;
        }

    }
    private void Move()
    {
        
        //Debug.Log("X axis: " + this.xDir + ", movespeed: " + this.movement.x);

        if (this.yDir == Direction.UP)
        {
            this.movement.y = this.speed;
            this.spMovement.y = 1;
        }

        if (this.yDir == Direction.DOWN)
        {
            this.movement.y = -1 * this.speed;
            this.spMovement.y = -1;
        }

        if (this.xDir == Direction.RIGHT)
        {
            this.movement.x = this.speed;
            this.spMovement.x = 1;
        }

        if (this.xDir == Direction.LEFT)
        {
            this.movement.x = -1 * this.speed;
            this.spMovement.x = -1;
        }

        if (this.yDir == Direction.NONE)
        {
            this.movement.y = 0;
            this.spMovement.y = 0;
        }

        if (this.xDir == Direction.NONE)
        {
            this.movement.x = 0;
            this.spMovement.x = 0;
        }

        this.rb.velocity = this.movement;
    }


}
