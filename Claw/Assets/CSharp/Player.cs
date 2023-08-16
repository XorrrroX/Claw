using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float shootSpeed = 10f;
    public float swingForce = 20f; // 用於擺動的力大小
    public float maxSwingDistance = 20f; // 最大擺動距離
    public GameObject claw;
    private Camera mainCamera;
    private GameObject currentClaw;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootClaw();
        }
        if (Input.GetButtonUp("Fire1") && currentClaw != null)
        {
            ReleaseClaw();
        }
    }

    private void FixedUpdate()
    {
        if (currentClaw != null)
        {
            ApplySwingForce();
        }
    }
    private void ShootClaw()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mainCamera.nearClipPlane; // 設置滑鼠 Z 座標為攝影機近平面的位置
        Vector3 targetPosition = mainCamera.ScreenToWorldPoint(mousePosition);

        Vector3 shootDirection = (targetPosition - transform.position);
        shootDirection = shootDirection / Mathf.Sqrt((shootDirection.x * shootDirection.x) + (shootDirection.y * shootDirection.y));

        GameObject clawInstance = Instantiate(claw, transform.position, Quaternion.identity, transform);
        Rigidbody2D clawRigidbody = clawInstance.GetComponent<Rigidbody2D>();

        Collider2D playerCollider = GetComponent<Collider2D>();
        Collider2D clawCollider = clawInstance.GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(playerCollider, clawCollider, true);

        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
        clawInstance.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        currentClaw = clawInstance;

        clawRigidbody.velocity = shootDirection * shootSpeed;
    }
    private void ReleaseClaw()
    {
        Destroy(currentClaw);
        currentClaw = null;
    }

    private void ApplySwingForce()
    {
        Claw clawController = currentClaw.GetComponent<Claw>();
        if (clawController != null && clawController.isCaught()) // 檢查爪子是否抓住物體
        {
            Vector2 playerToClaw = currentClaw.transform.position - transform.position;
            float distance = playerToClaw.magnitude;

            if (distance <= maxSwingDistance)
            {
                Vector2 swingDirection = playerToClaw.normalized;
                Vector2 force = swingDirection * swingForce;
                GetComponent<Rigidbody2D>().AddForce(force);
            }
        }
    }
}
