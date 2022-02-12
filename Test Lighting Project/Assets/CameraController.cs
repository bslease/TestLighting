using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float RotateSpeed = 20.0f;
    public float IdleRotateSpeed = 5.0f;
    public float maxIdleTime = 10.0f;
    private float timeSinceInput = 0.0f;

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        if (hInput == 0.0f)
        {
            timeSinceInput += Time.deltaTime;
            if (timeSinceInput > maxIdleTime)
            {
                transform.Rotate(new Vector3(0, IdleRotateSpeed * Time.deltaTime, 0));
            }
        }
        else
        {
            timeSinceInput = 0.0f;
            transform.Rotate(new Vector3(0, -hInput * RotateSpeed * Time.deltaTime, 0));
        }
    }
}
