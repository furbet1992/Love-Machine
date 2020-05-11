using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    //[SerializeField]
    //private float xMax;
    //[SerializeField]
    //private float yMax;
    //[SerializeField]
    //private float xMin;
    //[SerializeField]
    //private float yMin;

    //private bool activatePlayer1 = true;
    //private bool activatePlayer2 = true;

    private Transform target;
    public float xOffset;
    public float yOffset; 




    void Start()
    {
        target = GameObject.Find("Player_1").transform; 
    }

    // Update is called once per frame
    void LateUpdate()
    {

        // transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), Mathf.Clamp(target.position.y, yMin, yMax), transform.position.z); 

        Vector3 temp = transform.position;

        temp.x = target.position.x;

        temp.y = target.position.y; 

        temp.x += xOffset;
        temp.y += yOffset; 

        transform.position = temp;

    }
}
