using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ball : MonoBehaviour
{
    public static ball Instance;
    private Rigidbody rb;

    public float force = 5.0f;
    public float acceleration = 5.0f;
    bool isGround = false;

    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
    private void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * acceleration, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * acceleration, ForceMode.Force);
        }
    }
}
