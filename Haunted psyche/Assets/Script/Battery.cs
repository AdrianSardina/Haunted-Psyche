using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour,IsItem
{
    string name;
    float chargeRate;
    string IsItem.Name => name;

    private void Start()
    {
        name = "Battery";
        chargeRate = 50;
    }
    void IsItem.grab()
    {
        throw new System.NotImplementedException();
    }

    
}
