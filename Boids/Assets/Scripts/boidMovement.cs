using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boidMovement : MonoBehaviour
{
    [SerializeField] float boidSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * boidSpeed * Time.deltaTime);
    }
}
