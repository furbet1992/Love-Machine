﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // the gameobject of players o know which to switch it out from
    public Player player1;
    public Mom player2;


    // switch statement that has the case of when A button is pressed it switches
    private int switchPlayers = 1;

    // switch object int

    public Camera cameraZoom;

    //change sprite
    public SpriteRenderer mom; 
    public Sprite momHuman;
    public Sprite momGhost; 



    void Start()
    {
        player1.GetComponent<Player>().enabled = true;
        player2.GetComponent<Mom>().enabled = false;

        //mom.GetComponent<SpriteRenderer>();
        //momHuman = Resources.Load<Sprite>("mother(living)");
        //momGhost = Resources.Load<Sprite>("mother(ghost)");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))

        {
            switch (switchPlayers)
            {

                case 1:
                    switchPlayers = 2;

                    //player 1 script get set active :      player 2 script gets disable. 
                    //maybe can tap into the Player screen and change the value or x,y,z to be vector.zero
                    player1.GetComponent<Player>().enabled = false;
                    player2.GetComponent<Mom>().enabled = true;
                    player2.GetComponent<Mom>().spawnCount = 0;

                
                    //cameraZoom.GetComponent<Camera>().fieldOfView = 50; 

                    break;


                case 2:
                    switchPlayers = 1;

                    //player 2 script gets set active:      player 1 scripts set disable. 
                    player1.GetComponent<Player>().enabled = true;
                    player2.GetComponent<Mom>().enabled = false;

                    //cameraZoom.GetComponent<Camera>().fieldOfView = 33;

                    break; 
            }


        }





    }
}
