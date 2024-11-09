using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D rigid;
    [SerializeField] float velocitym;
    [SerializeField] float forcej;
    float valuem;
    [SerializeField] Transform detector;
    [SerializeField] float radius;
    [SerializeField] bool Isgrounded;
    public LayerMask mask;
    SpriteRenderer Sprite;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Isgrounded = Physics2D.OverlapCircle(detector.position, radius,mask);

        valuem = Input.GetAxis("Horizontal");

        anim.SetBool("Inmovement", valuem != 0 ? true : false);

        anim.SetBool("Isgrounded", Isgrounded);

        rigid.velocity = new Vector2(valuem * velocitym, rigid.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && Isgrounded)
        {
            rigid.AddForce(new Vector3(0, forcej, 0));
        }

        anim.SetFloat("height", rigid.velocity.y);

        flip();
    }

    private void flip()
    {
        if (valuem > 0 && Sprite.flipX == true || valuem < 0 && Sprite.flipX == false)
        {
            Sprite.flipX = !Sprite.flipX;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(detector.position, radius);
    }
}
