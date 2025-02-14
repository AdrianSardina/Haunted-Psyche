using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour,IPickable
{
    new string name;
    float chargeRate;
    Flashlight flashlight;
    string IPickable.Name => name;

    private void Start()
    {
        flashlight = FindAnyObjectByType<Flashlight>();
        name = "Battery";
        chargeRate = 50;
    }
    void IPickable.PickUp()
    {
        flashlight.Recharge(chargeRate);
        Debug.Log("linterna recargada");
        Destroy(gameObject);
    }

    
}
