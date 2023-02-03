using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Figure
{
    private Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        InvokeRepeating("Jump", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Jump() // ABSTRACTION
    {
        body.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}
