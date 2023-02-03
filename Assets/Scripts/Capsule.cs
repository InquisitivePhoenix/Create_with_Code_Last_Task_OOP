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
        //StartCoroutine(Wait());
    }

    private void Jump()
    {
        body.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Jump();
    }
}
