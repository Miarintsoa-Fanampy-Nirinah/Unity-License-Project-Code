using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float mouseSensitivity = 2.0f;
    public float jumpForce = 5.0f;
    public float gravity = 20.0f;

    private CharacterController characterController;
    private Camera playerCamera;
    private Vector3 moveDirection = Vector3.zero;

    private float rotationX = 0;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerCamera = GetComponentInChildren<Camera>();

        // Hide and lock cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    
}


