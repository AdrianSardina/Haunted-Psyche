using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pills : MonoBehaviour,IsItem
{
    PlayerScript playerScript;
    string name;
    float raiseAmount;
    public string Name => name;

    
    public void grab()
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
