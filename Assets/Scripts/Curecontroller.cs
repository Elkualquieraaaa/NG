using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curecontroller : MonoBehaviour
{
    [SerializeField] float cura;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<HealthController>())
        {
            collision.GetComponent<HealthController>().recibircura(cura);
            Destroy(gameObject);
        }
    }
}
