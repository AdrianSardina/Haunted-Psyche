using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int pickedFragments;
    int totalFragments;
    void Start()
    {
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

}
