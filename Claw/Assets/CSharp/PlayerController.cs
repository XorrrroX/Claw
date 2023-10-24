using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject box;
    public GameObject claw;
    public float shootSpeed = 10f;
    public float swingForce = 20f;
    public float maxSwingDistance = 20f;
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
        Vector3 targetPosition = GetTargetPosition();
        Vector3 shootDirection = GetNormalizedDirection(targetPosition);
        InstantiateClaw(shootDirection);
    }
    private Vector3 GetTargetPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mainCamera.nearClipPlane;
        Vector3 targetPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        return targetPosition;
    }
    private Vector3 GetNormalizedDirection(Vector3 targetPosition)
    {
        Vector3 shootDirection = (targetPosition - transform.position);
        shootDirection = shootDirection / Mathf.Sqrt((shootDirection.x * shootDirection.x) + (shootDirection.y * shootDirection.y));
        return shootDirection;
    }
    private void InstantiateClaw(Vector3 shootDirection)
    {
        GameObject clawInstance = Instantiate(claw, transform.position, Quaternion.identity, transform);
        Rigidbody2D clawRigidbody = clawInstance.GetComponent<Rigidbody2D>();
        SetupCollider(clawInstance);
        SetupRotation(clawInstance, shootDirection);
        currentClaw = clawInstance;
        clawRigidbody.velocity = shootDirection * shootSpeed;
    }
    private void SetupCollider(GameObject clawInstance)
    {
        Collider2D playerCollider = GetComponent<Collider2D>();
        Collider2D clawCollider = clawInstance.GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(playerCollider, clawCollider, true);

    }
    private void SetupRotation(GameObject clawInstance , Vector3 shootDirection)
    {
        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
        clawInstance.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    private void ReleaseClaw()
    {
        Destroy(currentClaw);
        currentClaw = null;
    }

    private void ApplySwingForce()
    {
        ClawController clawController = currentClaw.GetComponent<ClawController>();
        if (clawController != null && clawController.isCaught())
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
