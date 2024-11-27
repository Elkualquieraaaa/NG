using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Simulationmanagement : MonoBehaviour
{
    public static Simulationmanagement instance;

    [SerializeField] CharacterMovement character;

    public Scorecontroller scorecontroller;
    public FruitCounter FruitCounter;
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

    private void FixedUpdate()
    {
        if (FruitCounter.currentfruit == 17)
        {
            SceneManager.LoadScene(1);
        }
    }
}
