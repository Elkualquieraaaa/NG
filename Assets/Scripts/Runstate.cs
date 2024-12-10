using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runstate : Basestate
{
    public Runstate(CharacterMovement parametercharacter) : base(parametercharacter)
    {

    }
    public override void Entradastatus()
    {
        character.animator.Play("run_Maincharacter");
    }

    public override void Updatestatus()
    {
        if (character.tocandoelsuelo)
        {
            if (Input.GetKeyDown(character.keyjump))
            {
                Exitstatus(character.jump);
            }

            if (character.horizontal == 0)
            {
                Exitstatus(character.idle);
            }
        }
        if (character.tocandoelsuelo != true && character.rigid.velocity.y < 0)
        {
            Exitstatus(character.fall);
        }
    }
    public override void Fixedupdatestatus()
    {
        character.rigid.velocity = new Vector2(character.horizontal*character.forcem,character.rigid.velocity.y);
    }

    public override void Exitstatus(Basestate newstate)
    {
        character.Changestate(newstate);
    }
}
