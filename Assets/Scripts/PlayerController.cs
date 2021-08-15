using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Collider2D _collider2D;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    public LayerMask ground;
    
    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        float hDirection = Input.GetAxis("Horizontal");

        if (hDirection < 0.0f)
        {
            _rigidbody2D.velocity = new Vector2(-5f, _rigidbody2D.velocity.y);
            _spriteRenderer.flipX = true;
            _animator.SetBool("isRunning", true);
        } 
        else if (hDirection > 0.0f)
        {
            _rigidbody2D.velocity = new Vector2(5f, _rigidbody2D.velocity.y);
            _spriteRenderer.flipX = false;
            _animator.SetBool("isRunning", true);
        }
        else
        {
            _rigidbody2D.velocity = new Vector2(0f, _rigidbody2D.velocity.y);
            _animator.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && _collider2D.IsTouchingLayers(ground))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, 5f);
        }
    }
}
