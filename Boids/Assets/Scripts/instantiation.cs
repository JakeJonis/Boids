using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiation : MonoBehaviour
{
    [SerializeField] GameObject Boid;
    [SerializeField] int numBoids;
    [SerializeField] float velocity;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numBoids; i++)
        {
            Instantiate(Boid, Vector3.zero, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
