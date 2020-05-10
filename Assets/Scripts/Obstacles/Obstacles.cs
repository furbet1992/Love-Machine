using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX; 
            
        }   
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player2")
        {
            rb.constraints = RigidbodyConstraints2D.None;

        }
    }
}

