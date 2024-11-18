using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chameleonmovement : MonoBehaviour
{
    Collider2D objetive;
    Rigidbody2D rigid;
    Animator anim;

    public float distance;
    public float velocidad;
    public Transform visionfield;
    public Vector2 visionsize;
    public LayerMask detectionlayer;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        objetive = Physics2D.OverlapBox(visionfield.position, visionsize, 0, detectionlayer);
        anim.SetBool("targetdetected",objetive);

        if (objetive != null)
        {
            distance = Vector2.Distance(transform.position, objetive.transform.position);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(visionfield.position, visionsize);
    }
}
