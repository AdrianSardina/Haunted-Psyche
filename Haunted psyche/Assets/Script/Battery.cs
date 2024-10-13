using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour,IsItem
{
    new string name;
    float chargeRate;
    Flashlight flashlight;
    string IsItem.Name => name;

    private void Start()
    {
        flashlight = FindAnyObjectByType<Flashlight>();
        name = "Battery";
        chargeRate = 50;
    }
    void IsItem.grab()
    {
        flashlight.Recharge(chargeRate);
        Debug.Log("linterna recargada");
        Destroy(gameObject);
    }

    
}
