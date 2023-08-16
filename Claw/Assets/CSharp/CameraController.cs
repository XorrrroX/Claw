using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float newCameraSize = 5f;
    void Start()
    {
        Camera.main.orthographicSize = newCameraSize;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x,player.position.y,-20f);
    }
}
