using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Rigidbody rb;
    public float aVelocity;
    // Start is called before the first frame update
    void Start()
    {
        aVelocity = 3;
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere*aVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
