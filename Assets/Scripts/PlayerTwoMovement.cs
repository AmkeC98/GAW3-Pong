using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    public GameObject paddle;
    public float speed = 2.0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            paddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            paddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else
        {
            paddle.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
