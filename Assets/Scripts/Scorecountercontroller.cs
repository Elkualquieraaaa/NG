using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorecountercontroller : MonoBehaviour
{
    TextMeshProUGUI textMeshPro;
    [SerializeField] Scorecontroller scoreController;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = scoreController.currentscore.ToString();
    }
}
