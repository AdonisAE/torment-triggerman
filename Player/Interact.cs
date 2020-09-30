using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public bool pressed = false;
    // Update is called once per frame
    void Update()
    {
        //IF the user presses Q
        if (Input.GetKeyDown(KeyCode.E))
        {

            //Quit the game
            pressed = true;
        }
        else
        {
            pressed = false;
        }


    }
}
