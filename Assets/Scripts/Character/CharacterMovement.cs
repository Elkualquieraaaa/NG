using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rigid;
    BaseEstado estadoActual;
    public StateRun run;
    public StateIdle idle;
    public StateFall fall;
    public StateJump jump;
    
    public float fuerzaSalto;
    public float horizontal;
    [SerializeField] Transform centroDeteccion;
    [SerializeField] LayerMask capasDeteccion;
    [SerializeField] Vector2 tamañoDeteccion;
    public bool tocandoPiso;
    public KeyCode teclaSalto;

    public float velocidad;

  

    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        run = new StateRun(this);
        idle = new StateIdle(this);
        fall = new StateFall(this);
        jump = new StateJump(this);
        

        CambiarEstado(idle);
    }


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        estadoActual.UpdateEstado();
        Flip();
    }
    private void FixedUpdate()
    {
        estadoActual.FixedUpdateEstado();

        tocandoPiso = Physics2D.OverlapBox(centroDeteccion.position, tamañoDeteccion, 0, capasDeteccion);
    }

    public void CambiarEstado(BaseEstado nuevoEstado)
    {
        estadoActual = nuevoEstado;
        estadoActual.EntradaEstado();
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(centroDeteccion.position, tamañoDeteccion);
    }
    public void Flip()
    {
        if (horizontal < 0 && transform.localEulerAngles.y == 0 || horizontal > 0 && transform.localEulerAngles.y == 180)
        {
            transform.localEulerAngles = new Vector3(transform.eulerAngles.x, horizontal > 0 ? 0 : 180, transform.eulerAngles.z);
        }
    }
}
