using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chameleonmovement : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
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
        Debug.Log(Physics2D.OverlapBox(visionfield.position, visionsize, 0));
       
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(visionfield.position, visionsize);
    }
}
