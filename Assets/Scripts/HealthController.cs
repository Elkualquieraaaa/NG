using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] float vida;
    [SerializeField] float vidamax;

    public void recibirdaño(float daño)
    {
        vida -= daño;

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void recibircura(float cura)
    {
        vida += cura;

        if (vida > vidamax)
        {
            vida = vidamax;
        }
    }
}
