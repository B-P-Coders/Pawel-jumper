using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform transform;
    [SerializeField]
    private float Speed = 0.001f;
    [SerializeField]
    private float JumpForce = 1;
    private Rigidbody2D rb;
    private SpriteRenderer srender;
    private bool canJump;

    void Start()
    {
        transform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        srender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float axes = Input.GetAxis("Horizontal");
        if (axes > 0)
        {
            srender.flipX = true;
        } 
        else if (axes < 0)
        {
            srender.flipX = false;
        }

        transform.Translate(new Vector3(axes*Speed, 0, 0));
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector2.up*JumpForce);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;
    }
}
