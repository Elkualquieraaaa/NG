using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  BaseEstado
{
   
        public BaseEstado(CharacterMovement controller)
        {
            controlador = controller;
        }

    protected BaseEstado(CharacterController controller)
    {
        Controller = controller;
    }

    protected CharacterMovement controlador;

    public CharacterController Controller { get; }

    public abstract void EntradaEstado();

        public abstract void UpdateEstado();

        public abstract void FixedUpdateEstado();

        public abstract void SalidaEstado(BaseEstado nuevoEstado);

}