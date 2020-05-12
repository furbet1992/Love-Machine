using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{

    public GameObject entrance_door;
    private int triggerAmount = 0;


    public GameObject lightOff; 

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "player2" && Input.GetKey(KeyCode.E)  && triggerAmount ==0 )
        {
            Debug.Log("lever activate");
            entrance_door.transform.position += new Vector3(0, 1.5f);
            triggerAmount = 1;
            lightOff.SetActive(false); 
        }
    }

}
