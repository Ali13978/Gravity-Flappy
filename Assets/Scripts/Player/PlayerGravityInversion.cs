using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravityInversion : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool gamestarted;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (!gamestarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gamestarted = true;
                Time.timeScale = 1f;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.gravityScale = -1 * rb.gravityScale;
                transform.localScale = -1 * transform.localScale;
            }
        }
    }
}
