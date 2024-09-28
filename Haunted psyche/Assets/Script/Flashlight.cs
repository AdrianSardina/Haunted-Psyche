using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour,ISwitchable
{
    bool isActive;

    bool ISwitchable.IsActive => isActive;

    private void Start()
    {
        isActive = false; 
    }

    void ISwitchable.Toggle()
    {
        if (isActive)
        {
            isActive = false;
            Debug.Log("linterna apagada");
        }
        else
        {
            isActive = true;
            Debug.Log("linterna prendida");
        }
    }

    
}
