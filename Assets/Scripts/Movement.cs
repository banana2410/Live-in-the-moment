using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 10f;

    public Transform feetPos;
    public LayerMask whatIsGround;

    private Rigidbody2D _rb;
    private PlayerInput _playerInput;


    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _playerInput = gameObject.GetComponent<PlayerInput>();
    }

    void Update()
    {
        if (canJump() && _playerInput.NeedToJump())
        {
            jump();
        }
    }
    private void FixedUpdate()
    {
        move();
    }
    private void move()
    {
        _rb.velocity = new Vector2(_playerInput.ButtonInput * speed, _rb.velocity.y);
    }
    private void jump()
    {
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private bool canJump()
    {
        RaycastHit2D hit = Physics2D.Raycast(origin: feetPos.position, direction: Vector2.down, distance: 0.2f, layerMask: whatIsGround);
        if (hit.collider != null)
            return true;

        else
            return false;
    }
}
