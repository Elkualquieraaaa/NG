using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorecontroller : MonoBehaviour
{
    [SerializeField] int currentscore = 0;


    public void Addscore(int score)
    {
        currentscore += score;
    }
}
