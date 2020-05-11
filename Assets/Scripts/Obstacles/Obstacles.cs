using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Rigidbody2D rb;

    //tranform of obstacle location 
    public Transform spawn;

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
        if (collision.gameObject.tag == "player2" && Input.GetKey(KeyCode.E))
        {
            //rb.constraints = RigidbodyConstraints2D.None;
            this.gameObject.transform.position = spawn.transform.position;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player2" && Input.GetKey(KeyCode.E))
        {
            Debug.Log("interact"); 
            //rb.constraints = RigidbodyConstraints2D.None;
            this.gameObject.transform.position = spawn.transform.position;

        }
    }
    
}

