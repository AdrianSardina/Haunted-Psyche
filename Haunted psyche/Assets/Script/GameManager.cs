using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    int pickedFragments;
    int totalFragments;
    PlayerScript player;

    void Start()
    {
        player = FindAnyObjectByType<PlayerScript>();
        pickedFragments = 0;
        totalFragments = 6;
       
    }

    public void AddFragment()
    {
        pickedFragments++;
        Debug.Log(pickedFragments);
        if (pickedFragments == totalFragments) 
        {
            //Victoria
        }
        
        //Sonidos
    }
    private void Update()
    {
        
    }
}
