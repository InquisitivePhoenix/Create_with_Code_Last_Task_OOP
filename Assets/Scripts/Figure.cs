using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    private float speed = 10;
    protected float Speed
    {
        get { return speed; }
        set { speed = value; }
    } // ENCAPSULATION
    // Start is called before the first frame update
    protected virtual void MoveForward()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
    }
}
