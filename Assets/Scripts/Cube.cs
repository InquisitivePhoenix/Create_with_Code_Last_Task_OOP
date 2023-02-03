using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Figure
{
    private Vector2 leftTopCorner = new Vector2 (20, -10);
    private Vector2 rightTopCorner = new Vector2 (10, -10);
    private Vector2 leftBottomCorner = new Vector2 (20, 0);
    private Vector2 rightBottomCorner = new Vector2 (10, 0);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(20, 2, -10);
    }

    // Update is called once per frame
    void Update()
    {
        MoveCircle();
    }

    private void MoveRight()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void MoveCircle()
    {
        MoveRight();
        MoveForward();
        if (transform.position.x > 20 || transform.position.x < 10)
        {
            speed *= -1;
        }
    }
}
