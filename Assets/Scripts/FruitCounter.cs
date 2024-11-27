using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCounter : MonoBehaviour
{
    public int currentfruit = 0;

    public void Addnum(int num)
    {
        currentfruit += num;
    }
}
