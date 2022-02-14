using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    private Vector3 startPosition;
    private Rigidbody rb;

    private void Start()
    {
        startPosition = transform.position;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < -10.0f)
        {
            //Destroy(gameObject);
            rb.velocity = Vector3.zero;
            transform.position = startPosition;
        }
    }
}
