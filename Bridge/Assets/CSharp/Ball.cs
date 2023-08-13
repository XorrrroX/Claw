using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度
    public float maxSpeed = 10f; // 最大速度

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // 獲取水平輸入

        // 根據按鍵輸入施加力量
        if (horizontalInput != 0)
        {
            Vector2 moveDirection = new Vector2(horizontalInput, 0);
            rb.AddForce(moveDirection * moveSpeed);

            // 限制最大速度
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed), rb.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")) // 根據斜面的Tag進行判定
        {
            Vector2 normal = collision.contacts[0].normal;
            Vector2 reflectedDirection = Vector2.Reflect(transform.right, normal); // 反射方向
            GetComponent<Rigidbody2D>().velocity = reflectedDirection.normalized * GetComponent<Rigidbody2D>().velocity.magnitude;
        }
    }
}
