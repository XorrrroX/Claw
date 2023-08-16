using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Claw : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool hasCollided = false; // 紀錄是否碰撞過

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor") && !hasCollided)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            hasCollided = true;
        }
    }
    public bool isCaught()
    {
        return hasCollided;
    }

    private void Update()
    {
        if (!hasCollided)
        {
            // 在碰撞前，可以在這裡處理爪子的移動邏輯
        }
    }
}
