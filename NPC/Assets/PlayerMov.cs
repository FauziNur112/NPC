using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerMov : MonoBehaviour
{

    public float moveSpeed = 30f;

    public Rigidbody2D rb;

    public Animator m_animator;

    Vector2 movement;

    void Start()
    {
        m_animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
       movement.x = UnityEngine.Input.GetAxisRaw("Horizontal");
       movement.y = UnityEngine.Input.GetAxisRaw("Vertical");

        if (movement.x > 0)
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (movement.x < 0)
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

       

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
