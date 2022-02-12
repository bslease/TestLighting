using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float RotateSpeed = 1.0f;

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, -hInput*RotateSpeed, 0));
    }
}
