using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Idlestate : Basestate
{
    public Idlestate(CharacterMovement parametercharacter) : base(parametercharacter)
    {

    }
    public override void Entradastatus()
    {
        character.animator.Play("idle_Maincharacter");
        character.rigid.velocity = new Vector2(0,character.rigid.velocity.y);
    }

    public override void Updatestatus()
    {
        if (character.tocandoelsuelo)
        {
            if (Input.GetKeyDown(character.keyjump))
            {
                Exitstatus(character.jump);
            }

            if (character.horizontal != 0)
            {
                Exitstatus(character.run);
            }
        }
        if (character.rigid.velocity.y < 0 && character.tocandoelsuelo != true)
        {
            Exitstatus(character.fall);
        }
    }
    public override void Fixedupdatestatus()
    {
    }

    public override void Exitstatus(Basestate newstate)
    {
        character.Changestate(newstate);
    }
}
