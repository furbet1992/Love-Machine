using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soil : MonoBehaviour
{

    public GameObject soilReplacement;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "soil")
        {
            Debug.Log("soil activate");
            soilReplacement.SetActive(true);
            Destroy(collision.gameObject); 
        }
    }

}
