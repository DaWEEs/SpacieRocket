using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 7f; //Rychlost pohybu rakety po ose Y
    public Rigidbody2D rb; 
    public Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        movement.y = Input.GetAxis("Vertical"); //+1 nebo -1 podle 
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
