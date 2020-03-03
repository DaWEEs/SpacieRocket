using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 movement;

    public float speedX = 0.5f;
    // Update is called once per frame
    void Update()
    {
        movement.x -= speedX * Time.deltaTime;
        rb.MovePosition(rb.position + speedX * movement * Time.deltaTime);
    }

}
