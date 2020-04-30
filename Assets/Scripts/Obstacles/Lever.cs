using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{

    public GameObject entrance_door;
    private int triggerAmount = 0; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "player2" && triggerAmount==0)
        {
            entrance_door.transform.position += new Vector3(0, 2);
            triggerAmount = 1; 
        }
    }

}
