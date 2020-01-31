using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed = (2 * Mathf.PI)/10;
    private float Theta = 0f; //starting theta
    private int radius = 6; //radius

    void Update()
    {
        Theta += speed * Time.deltaTime;
        float x = radius * Mathf.Sin(Theta);
        float z = radius * Mathf.Cos(Theta);
        transform.position = new Vector3(x, 6f, z);
    }
}
