using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        movement = Vector2.zero;

        if (keyboard.wKey.isPressed) movement.y = 1;
        if (keyboard.sKey.isPressed) movement.y = -1;
        if (keyboard.aKey.isPressed) movement.x = -1;
        if (keyboard.dKey.isPressed) movement.x = 1;

        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * speed;
    }
}
