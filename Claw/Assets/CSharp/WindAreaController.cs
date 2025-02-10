using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindAreaController : MonoBehaviour
{
    public float fanForce = 10f; 
    public Vector2 windDirection = Vector2.up; 

    private void OnTriggerStay2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.AddForce(windDirection.normalized * fanForce);
        }
    }
}
