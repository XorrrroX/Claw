using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float newCameraSize = 10f;
    public float zoomSpeed = 1f;
    void Start()
    {
        Camera.main.orthographicSize = newCameraSize;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x,player.position.y,-20f);
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        if (scrollInput != 0f)
        {
            ChangeCameraSize(scrollInput);
        }
    }
    private void ChangeCameraSize(float scrollInput)
    {
        Camera mainCamera = Camera.main;
        float currentCameraSize = mainCamera.orthographicSize;

        float newCameraSize = Mathf.Clamp(currentCameraSize - scrollInput * zoomSpeed, 1f, Mathf.Infinity);
        mainCamera.orthographicSize = newCameraSize;
    }
}
