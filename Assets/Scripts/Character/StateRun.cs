using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateRun : BaseEstado
{
  
    public StateRun(CharacterMovement controller) : base(controller)
    {
    }

    public override void EntradaEstado()
    {
        controlador.anim.Play("run");
    }

    public override void UpdateEstado()
    {
        if (controlador.rigid.velocity.y <= 0)
        {
            if (controlador.tocandoPiso)
            {
                if (Input.GetKeyDown(controlador.teclaSalto))
                {
                    SalidaEstado(controlador.jump);
                }
                else if (controlador.horizontal == 0)
                {
                    SalidaEstado(controlador.idle);
                }
                else
                {
                    SalidaEstado(controlador.fall);
                }
            }
        }

    }

    public override void FixedUpdateEstado()
    {
        controlador.rigid.velocity = new Vector2(controlador.horizontal * controlador.velocidad, controlador.rigid.velocity.y);
    }

    public override void SalidaEstado(BaseEstado nuevoEstado)
    {
        controlador.CambiarEstado(nuevoEstado);
    }
}
