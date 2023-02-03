using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Figure
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(20, 2, -10);
    }

    // Update is called once per frame
    void Update()
    {
        //MoveRight();
        MoveForward();
    }

    private void MoveRight()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }

    protected override void MoveForward() //POLYMORPHISM
    {
        MoveRight();
        base.MoveForward(); // INHERITACNE
        if (transform.position.x > 20 || transform.position.x < 10)
        {
            Speed *= -1;
        }
    }
}
