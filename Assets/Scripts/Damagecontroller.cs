using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagecontroller : MonoBehaviour
{
    [SerializeField] float da�o;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HealthController>())
        {
            collision.gameObject.GetComponent<HealthController>().Recibirda�o(da�o);
        }
    }
}
