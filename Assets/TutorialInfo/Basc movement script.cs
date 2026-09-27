using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public float walkSpeed = 5f;
    public float runSpeed = 8f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Keyboard.current == null)
            return;

        Vector3 move = Vector3.zero;

        if (Keyboard.current.wKey.isPressed) move += Vector3.forward;
        if (Keyboard.current.sKey.isPressed) move += Vector3.back;
        if (Keyboard.current.aKey.isPressed) move += Vector3.left;
        if (Keyboard.current.dKey.isPressed) move += Vector3.right;

        move.Normalize();

        float speed = Keyboard.current.leftShiftKey.isPressed ? runSpeed : walkSpeed;

        rb.linearVelocity = transform.TransformDirection(
            new Vector3(move.x * speed, rb.linearVelocity.y, move.z * speed)
        );
    }
}