using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float hSpeed = 7f;
    public float vSpeed = 1f;

    private Animator _animator;
    private Rigidbody2D _rigidBody2D;

    // Use this for initialization
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hMove = Input.GetAxis("Horizontal");
        float vMove = Input.GetAxis("Vertical");

        if (Mathf.Abs(vMove) > Mathf.Abs(hMove)) {
            _animator.SetFloat("vMove", vMove);
            _animator.SetFloat("hMove", 0);
        } else if (Mathf.Abs(hMove) > Mathf.Abs(vMove)) {
            _animator.SetFloat("hMove", hMove);
            _animator.SetFloat("vMove", 0);
        } else {
            _animator.SetFloat("vMove", 0);
            _animator.SetFloat("hMove", 0);
        }

        _rigidBody2D.velocity = new Vector2(hMove * hSpeed, vMove * vSpeed);
    }

    void FixedUpdate()
    {
    }
}
