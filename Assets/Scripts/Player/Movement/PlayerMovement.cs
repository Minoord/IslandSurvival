using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 2f;
    [SerializeField] private float jumpForce = 4;
    [SerializeField] private float jumpThreshold = 0.0001f;
    private Rigidbody playerRigidbody;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    
    public void Walking(Vector3 position)
    {
        var moveDirection = new Vector3(position.x, 0, position.y);
        transform.position += moveDirection * speed * Time.deltaTime;
    }
    
    public void Jump(InputAction.CallbackContext context)
    {
        if(Mathf.Abs(playerRigidbody.velocity.y) < jumpThreshold)
            playerRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode.Impulse);
    }
    
}
