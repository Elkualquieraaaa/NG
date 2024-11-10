using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poinmovement : MonoBehaviour
{
    public List<Transform> points = new List<Transform>();
    [SerializeField] float velocity;
    int actualpoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[actualpoint].position, velocity * Time.deltaTime);


        if (transform.position == points[actualpoint].position)
        {
            actualpoint++;
            if (actualpoint > points.Count - 1)
            {
                actualpoint = 0;
            }
        }

    }
}
