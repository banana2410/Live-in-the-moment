using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private PlayerInput _playerInput;
    private SpriteRenderer _spriteRend;
    private Rigidbody2D _rb;
    private Animator _animator;
    private void Start()
    {
        _playerInput = gameObject.GetComponent<PlayerInput>();
        _animator = gameObject.GetComponent<Animator>();
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _spriteRend = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (_playerInput.NeedToAttack())
        {
            SetAttack();
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            SetRunning();
            transform.Rotate(new Vector3(0f, 0f, 0f));
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            SetRunning();
            transform.Rotate(new Vector3(0f, 180f, 0f));
        }
        if (_rb.velocity.x == 0)
            SetIdle();
    }
    public void SetRunning()
    {
        _animator.SetBool("IsRunning", true);
        _animator.SetBool("IsIdle", false);
        _animator.SetBool("IsAttack", false);
    }
    public void SetIdle()
    {
        _animator.SetBool("IsRunning", false);
        _animator.SetBool("IsIdle", true);
        _animator.SetBool("IsAttack", false);
    }
    public void SetAttack()
    {
        _animator.SetTrigger("Attack");
    }
}
