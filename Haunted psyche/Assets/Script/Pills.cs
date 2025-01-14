using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pills : MonoBehaviour,IPickable
{
    PlayerScript playerScript;
    string name;
    float raiseAmount;
    public string Name => name;

    
    public void PickUp()
    {
        playerScript.RaiseSanity(raiseAmount);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        playerScript = FindAnyObjectByType<PlayerScript>();
        raiseAmount = 25;
    }

    
}
