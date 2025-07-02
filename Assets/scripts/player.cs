using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float rollSpeed = 10f;
    [SerializeField] private float maxAngularVelocity = 20f;
    [SerializeField] private float tiltSensitivity = 2f;
    [SerializeField] private float airControl = 0.5f;
    [SerializeField] private float groundDrag = 1f;
    [SerializeField] private float airDrag = 0.2f;

    [Header("Ground Check")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundCheckDistance = 0.5f;

    private Rigidbody rb;
    private bool isGrounded;
    private Vector3 tiltInput;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = maxAngularVelocity;
    }
    private void Update()
    {

        tiltInput = new Vector3(Input.GetAxis("Vertical"),0f,-Input.GetAxis("Horizontal"));


        isGrounded = Physics.Raycast(
          transform.position,
          Vector3.down,
          groundCheckDistance,
          groundLayer
        );

        rb.linearDamping = isGrounded ? groundDrag : airDrag;

    }
    private void FixedUpdate()
    {
        if (isGrounded)
        {
            Vector3 torque = tiltInput * rollSpeed * tiltSensitivity;
            rb.AddTorque(torque, ForceMode.Acceleration);
        }
        else
        {
            //Vector3 airForce = tiltInput * rollSpeed * airControl;
            //rb.AddForce(airForce, ForceMode.Acceleration);
        }

    }
}