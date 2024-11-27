using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public delegate void Recibirdañodelegado(float health);
    public float vida;
    public float vidamax;

    public Recibirdañodelegado Dañorecibido;
    public Recibirdañodelegado Curarecibida;

    void Start()
    {
        vidamax = vida;
    }
    public void Recibirdaño(float daño)
    {
        vida -= daño;

        Dañorecibido?.Invoke(vida);

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

        Curarecibida?.Invoke(vidamax);
    }
}
