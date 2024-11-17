using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateFall : BaseEstado
{
    public StateFall(CharacterMovement controller) : base(controller)
    {
    }

    public override void EntradaEstado()
    {
        controlador.anim.CrossFade("fall", 0.1f);
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
