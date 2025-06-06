using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private float initialVelocity = 4f;
    private float velocityMultiplier = 1.2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? -1 : 1;
        float yVelocity = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            rb.velocity *= velocityMultiplier;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Goal1"))
        {
            GameManager.Instance.Paddle2Score();
            GameManager.Instance.Restart();
            Launch();

        }
        else if (collision.gameObject.CompareTag("Goal2"))
        {
            GameManager.Instance.Paddle1Score();
            GameManager.Instance.Restart();
            Launch();
        }
    }
}
