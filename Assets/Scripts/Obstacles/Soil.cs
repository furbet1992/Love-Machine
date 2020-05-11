using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soil : MonoBehaviour
{

    public GameObject soilReplacement;




    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player2" && Input.GetKey(KeyCode.E))
        {
            Debug.Log("soil activate");
            soilReplacement.SetActive(true);
            Destroy(this.gameObject); 
        }
    }

}
