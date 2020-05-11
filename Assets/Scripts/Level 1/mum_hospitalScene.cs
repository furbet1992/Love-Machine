using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mum_hospitalScene : MonoBehaviour
{
    Rigidbody2D rb;
    public float movementSpeed = 5f;

    private bool facingRight = true;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        handleMovement(horizontal);
    }
    private void handleMovement(float horizontal)
    {
        rb.velocity = new Vector2(horizontal * movementSpeed, rb.velocity.y);
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

}
