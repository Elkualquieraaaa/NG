using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Basestate
{

    public Basestate(CharacterMovement parametercharacter)
    {
        character = parametercharacter;
    }

    protected CharacterMovement character;
    public abstract void Entradastatus();

    public abstract void Updatestatus();
    public abstract void Fixedupdatestatus();

    public abstract void Exitstatus(Basestate newstate);


}
