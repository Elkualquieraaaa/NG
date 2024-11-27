using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitnum : MonoBehaviour
{
    [SerializeField] int num;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Simulationmanagement.instance.FruitCounter.Addnum(num);
        }
    }
}
