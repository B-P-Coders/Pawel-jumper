using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform transform;
    [SerializeField]
    private float Speed = 1;
    [SerializeField]
    private float JumpForce = 1;
    private Rigidbody2D rb;
    private SpriteRenderer srender;

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
    }
}
