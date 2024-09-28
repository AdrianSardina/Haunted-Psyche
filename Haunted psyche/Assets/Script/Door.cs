using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour,ISwitchable
{
    bool isActive;
    public bool IsActive => isActive;

    void Start()
    {
        isActive = true;
    }

    public void Toggle()
    {
        if (isActive)
        {
            isActive = false;
            Debug.Log("Puerta abierta");
        }
        else 
        {
            isActive = true;
            Debug.Log("Puerta cerrada");
        }
    }


}
