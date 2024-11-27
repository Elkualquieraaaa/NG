using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Simulationmanagement : MonoBehaviour
{
    public static Simulationmanagement instance;

    [SerializeField] CharacterMovement character;

    public Scorecontroller scorecontroller;
    public FruitCounter FruitCounter;
    public HealthController HealthController;
    public int actualscene;
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
        if (HealthController.vida <= 0)
        {
            reload(actualscene);
        }

        if (FruitCounter.currentfruit == 17)
        {
            SceneManager.LoadScene(1);
        }
    }

    private void reload (int scene)
        {
        SceneManager.LoadScene(scene);
        }
}
