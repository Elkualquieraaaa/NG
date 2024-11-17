using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemscor : MonoBehaviour
{
    [SerializeField] int score;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Simulationmanagement.instance.scorecontroller.Addscore(score);
            Destroy(gameObject);
        }
    }
}
