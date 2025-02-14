using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragment : MonoBehaviour, IPickable
{
    GameManager gameManager;
    private new string name;
    
    string IPickable.Name => name;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        name = "Fragmento";
        
    }



    void IPickable.PickUp()
    {
       gameManager.AddFragment();
       Destroy(this.gameObject);
    }
}
