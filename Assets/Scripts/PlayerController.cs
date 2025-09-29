using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

//[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private InputActionReference rightJumpActionReference;
    [SerializeField] private float jumpForce = 500;
    // Start is called before the first frame update

    private XROrigin xrRig;
    private CapsuleCollider collider;
    private Rigidbody body;


    private bool IsGrounded => Physics.Raycast(
        new Vector2(transform.position.x, transform.position.y + 2.0f),
        Vector3.down, 2.0f);


    void Start()
    {
        xrRig = GetComponent<XROrigin>();
        collider = GetComponent<CapsuleCollider>();
        body = GetComponent<Rigidbody>();
        jumpActionReference.action.performed += OnJump;
        rightJumpActionReference.action.performed += OnJump;
    }

    // Update is called once per frame
    void Update()
    {
        var center = xrRig.CameraInOriginSpacePos;
        collider.center = new Vector3(center.x, collider.center.y, center.z);
        collider.height = xrRig.CameraInOriginSpaceHeight;
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        if (!IsGrounded) return;
        body.AddForce(Vector3.up * jumpForce);
    }
}
