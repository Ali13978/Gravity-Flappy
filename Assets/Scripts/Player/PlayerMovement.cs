using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float startSpeed = 25f;

    private float moveSpeed;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = startSpeed;
    }

    private void Update()
    { 
        rb.velocity = new Vector2(moveSpeed * 10 * Time.deltaTime, rb.velocity.y);
    }
}







