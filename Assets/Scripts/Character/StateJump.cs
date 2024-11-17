using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateJump : BaseEstado
{
  
    public StateJump(CharacterMovement controller) : base(controller)
    {
    }

    public override void EntradaEstado()
    {
        controlador.anim.Play("jump");
        controlador.rigid.AddForce(Vector2.up * controlador.fuerzaSalto, ForceMode2D.Impulse);
    }

    public override void UpdateEstado()
    {

        if (controlador.rigid.velocity.y <= 0)
        {
            if (controlador.tocandoPiso)
            {
                if (controlador.horizontal == 0)
                {
                    SalidaEstado(controlador.idle);
                }
                else if (controlador.horizontal != 0)
                {
                    SalidaEstado(controlador.run);
                }
            }
            else
            {
                SalidaEstado(controlador.fall);
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
