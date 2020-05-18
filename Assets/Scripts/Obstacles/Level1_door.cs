using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Level1_door : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            Debug.Log("detected"); 
            //open door to the next scene
            SceneManager.LoadScene("Level 2"); 

        }
    }
}
