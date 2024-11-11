using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorecontroller : MonoBehaviour
{
    public int currentscore = 0;


    public void Addscore(int score)
    {
        currentscore += score;
    }
}
