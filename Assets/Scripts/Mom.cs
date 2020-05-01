using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mom : MonoBehaviour
{

    public float horizontalSpeed;
    public float verticalSpeed;

    //flipFace
    private bool facingRight = true;


    //player tranform
    public GameObject player;
    private bool startSpawn = true;
    public  int spawnCount = 0; 



    void Start()
    {
        this.gameObject.transform.position = player.transform.position + new Vector3(0f,2f,0f); 
    }

    // Update is called once per frame
    void Update()
    {
        if (startSpawn && spawnCount==0)
        {
            
            this.gameObject.transform.position = player.transform.position + new Vector3(0f, 2f, 0f);
            spawnCount = 1; 
        }


        if(spawnCount ==1)
        { 

            // mum floats like a real ghost in X axis
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-horizontalSpeed, 0, 0) * Time.deltaTime;
                this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(horizontalSpeed, 0, 0) * Time.deltaTime;
                this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }


            // float in the y axis
            if (Input.GetKey(KeyCode.W))
                transform.position += new Vector3(0, verticalSpeed, 0) * Time.deltaTime;

            if (Input.GetKey(KeyCode.S))
                transform.position += new Vector3(0, -verticalSpeed, 0) * Time.deltaTime;
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
