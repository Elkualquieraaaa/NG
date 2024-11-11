using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulationmanagement : MonoBehaviour
{
    public static Simulationmanagement instance;

    [SerializeField] CharacterMovement character;

    public Scorecontroller scorecontroller;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
