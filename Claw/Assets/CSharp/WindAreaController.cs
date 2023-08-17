using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindAreaController : MonoBehaviour
{
    public float fanForce = 10f; // 預設吹風力量
    public Vector2 windDirection = Vector2.up; // 自訂吹風方向

    private void OnTriggerStay2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // 使用 windDirection 控制吹風方向
            rb.AddForce(windDirection.normalized * fanForce);
        }
    }
}
