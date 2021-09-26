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

    void Start()
    {
        transform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position +=  new Vector3(0.01f, 0, 0) * Speed;
        if (Input.GetKeyDown(KeyCode.Space))
             rb.AddForce(Vector2.up * JumpForce);
    }
}
