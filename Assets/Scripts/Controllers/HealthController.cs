using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public delegate void Recibirda�odelegado(float health);
    public float vida;
    public float vidamax;

    public Recibirda�odelegado Da�orecibido;
    public Recibirda�odelegado Curarecibida;

    void Start()
    {
        vidamax = vida;
    }
    public void Recibirda�o(float da�o)
    {
        vida -= da�o;

        Da�orecibido?.Invoke(vida);

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
