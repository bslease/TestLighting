using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public float moveSpeed = 15.0f;
    public float jumpForce = 5.0f;
    private Rigidbody rb;
    private bool doJump;

    private void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            doJump = true;
        }
    }

    void FixedUpdate()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        rb.MovePosition(transform.position + new Vector3(hInput * moveSpeed * Time.fixedDeltaTime, 0, vInput * moveSpeed * Time.fixedDeltaTime));
        if (doJump)
        {
            doJump = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
