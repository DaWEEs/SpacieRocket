using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 movement;

    public float speedY = 7f;
    public float speedX = 0.25f;

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxis("Vertical");
        movement.x += speedX * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speedY * Time.fixedDeltaTime);
    }
}
