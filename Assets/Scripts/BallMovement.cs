using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float speed = 3.0f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * speed;   //Vector2.right = (1, 0)
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "PlayerOneLeft")
        {
            //Debug.Log("left racket");
            float y = calculatePosition(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            rb.velocity = direction * speed;
        }
        if (collision.gameObject.name == "PlayerTwoRight")
        {
            //Debug.Log("right racket");
            float y = calculatePosition(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;
            rb.velocity = direction * speed;
        }
    }

    float calculatePosition (Vector2 pBallPos, Vector2 pRacketPos, float pRacketHeight)
    {
        float value = (pBallPos.y - pRacketPos.y) / pRacketHeight;
        return value;
    }
}
