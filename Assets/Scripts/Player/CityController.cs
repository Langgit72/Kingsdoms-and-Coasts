using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class CityController : MonoBehaviour
{
    public float speed;

    public Animator m_animator;
    public Rigidbody2D m_rigidbody2D;
    public Vector2 direction;

    void Start()
    {
        m_rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        m_animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        m_rigidbody2D.velocity = direction * speed;
        m_animator.SetFloat("x", m_rigidbody2D.velocity.x);
        m_animator.SetFloat("y", m_rigidbody2D.velocity.y);

    }

    void OnWalk(InputValue value)
    {
        direction = value.Get<Vector2>();
    }
}
