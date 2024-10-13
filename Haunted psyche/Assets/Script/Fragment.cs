using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment : MonoBehaviour, IsItem
{
    GameManager gameManager;
    private new string name;
    
    string IsItem.Name => name;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        name = "Fragmento";
        
    }



    void IsItem.grab()
    {
       gameManager.AddFragment();
       Destroy(this.gameObject);
    }
}
