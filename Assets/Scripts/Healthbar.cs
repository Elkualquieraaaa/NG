using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField]HealthController healthController;
    [SerializeField] Image bar;

    private void Start()
    {
        healthController.Dañorecibido += Showbar;
        healthController.Curarecibida+= Showbar;
    }

    public void Showbar (float vida)
    {
        bar.fillAmount = (1 / healthController.vidamax) * vida;
    }

}
