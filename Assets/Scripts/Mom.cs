using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mom : MonoBehaviour
{

    public float horizontalSpeed;
    public float verticalSpeed;

    //flipFace
    private bool facingRight = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // mum floats like a real ghost in X axis
        if(Input.GetKey(KeyCode.A))
       transform.position += new Vector3(-horizontalSpeed, 0, 0) * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(horizontalSpeed, 0, 0) * Time.deltaTime;

        // float in the y axis
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, verticalSpeed, 0) * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, -verticalSpeed, 0) * Time.deltaTime;
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
