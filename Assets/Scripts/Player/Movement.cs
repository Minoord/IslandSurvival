using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    public float speed = 2f;
    public Rigidbody thisRigidbody;
    public float jumpForce;

    public void Jump(InputAction.CallbackContext context)
    {
        if(Mathf.Abs(thisRigidbody.velocity.y) < 0.001f)
        {
            thisRigidbody.AddForce(new Vector3(0, jumpForce), ForceMode.Impulse);
        }
    }

    public void Walking(Vector3 Pos)
    {
        Vector3 moveDir = new Vector3(Pos.x, 0, Pos.y);
        transform.position += moveDir * speed * Time.deltaTime;
    }
}
