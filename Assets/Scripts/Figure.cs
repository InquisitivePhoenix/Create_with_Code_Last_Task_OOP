using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    protected float speed = 10;
    // Start is called before the first frame update
    protected void MoveForward()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
    }
}
