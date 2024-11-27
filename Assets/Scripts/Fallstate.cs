using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallstate : Basestate
{

    public Fallstate(CharacterMovement parametercharacter) : base(parametercharacter) 
    {

    }  
    public override void Entradastatus()
    {
        character.animator.Play("Fall_Maincharacter");
    }

    public override void Updatestatus()
    {
        if (character.tocandoelsuelo)
        {
            if (character.horizontal == 0 && character.rigid.velocity.y == 0)
            {
                Exitstatus(character.idle);
            }
            if (character.horizontal != 0)
            {
                Exitstatus(character.run);
            }
        }
    }
    public override void Fixedupdatestatus()
    {
        character.rigid.velocity = new Vector2(character.horizontal * character.forcem, character.rigid.velocity.y);
    }

    public override void Exitstatus(Basestate newstate)
    {
        character.Changestate(newstate);
    }
}
