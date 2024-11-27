using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Animator animator;
    public Rigidbody2D rigid;
    Basestate actualstate;

    public Idlestate idle;
    public Runstate run;
    public Jumpstate jump;
    public Fallstate fall;
    public Transform detector;
    public LayerMask LayerMask;
    public bool tocandoelsuelo;
    public float radius;
    public float forcej;
    public float forcem;
    public KeyCode keyjump;

    public float horizontal;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        idle = new Idlestate(this);
        run = new Runstate(this);
        jump = new Jumpstate(this);
        fall = new Fallstate(this);

        Changestate(idle);
    }


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        actualstate.Updatestatus();
        flip();
    }

    private void FixedUpdate()
    {
        tocandoelsuelo = Physics2D.OverlapCircle(detector.position, radius, LayerMask);
        actualstate.Fixedupdatestatus();
    }

    public void Changestate(Basestate newstate)
    {
        actualstate = newstate;
        actualstate.Entradastatus();
    }
    private void flip()
    {
        if (horizontal > 0 && SpriteRenderer.flipX == true || horizontal < 0 && SpriteRenderer.flipX == false)
        {
            SpriteRenderer.flipX = !SpriteRenderer.flipX;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(detector.position, radius);
    }
}
