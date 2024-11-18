using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagecontroller : MonoBehaviour
{

    Collider2D col;
    [SerializeField] float daño;

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HealthController>())
        {
            collision.gameObject.GetComponent<HealthController>().Recibirdaño(daño);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthController healthController;

        if (collision.TryGetComponent(out healthController))
        {
            healthController.Recibirdaño(daño);
        }
    }

    public void Activatecollider()
    {
        col.enabled = true;
    }

    public void Desactivatecollider()
    {
        col.enabled = false;
    }

}
