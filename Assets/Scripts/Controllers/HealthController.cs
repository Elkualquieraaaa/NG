using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public delegate void Recibirdaņodelegado(float health);
    public float vida;
    public float vidamax;

    public Recibirdaņodelegado Daņorecibido;
    public Recibirdaņodelegado Curarecibida;

    void Start()
    {
        vidamax = vida;
    }
    public void Recibirdaņo(float daņo)
    {
        vida -= daņo;

        Daņorecibido?.Invoke(vida);

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
