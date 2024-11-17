using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : BaseEstado
{


    public StateIdle(CharacterMovement controller) : base(controller)
    {
    }

    public override void EntradaEstado()
    {
        controlador.anim.CrossFade ("idle", 0.1f);
        controlador.rigid.velocity = new Vector2(0, controlador.rigid.velocity.y);
    }

    public override void UpdateEstado()
    {
       
        if (controlador.rigid.velocity.y <=0)
        {
            if (controlador.tocandoPiso)
            {
                if (Input.GetKeyDown(controlador.teclaSalto))
                {
                    SalidaEstado(controlador.jump);
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

    }

    public override void SalidaEstado(BaseEstado nuevoEstado)
    {
        controlador.CambiarEstado(nuevoEstado);
    }
}
