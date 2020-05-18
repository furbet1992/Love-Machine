using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeless_Man : MonoBehaviour
{

    public GameObject speech1;
    public GameObject speech2;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            speech1.SetActive(false);
            speech2.SetActive(true);


        }

    }
}
