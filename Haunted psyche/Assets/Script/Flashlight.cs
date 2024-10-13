using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    bool isActive;
    float flashlightLevel;
    float maximunBattery;
    float drainRate;

    private void Start()
    {
        isActive = false; 
        flashlightLevel = 100;
        drainRate = 2;
        maximunBattery = 100;
    }

    public void Toggle()
    {
        if (isActive)
        {
            //Turn off
            isActive = false;
            StopCoroutine(Drain());
        }
        else
        {
            //Turn on
            isActive = true;
            StartCoroutine(Drain());
           
        }
    }
    private IEnumerator Drain()
    {
        

        while (flashlightLevel >=0 && isActive) 
        {
            Debug.Log(flashlightLevel);
            flashlightLevel -= drainRate;
            if (flashlightLevel < 0)
            {
                flashlightLevel = 0;
                Toggle();
            }
           yield return new WaitForSeconds(1f);
        }
        
        yield return null ;
    }
    public void Recharge( float amount) 
    {
        flashlightLevel =Mathf.Min(flashlightLevel+amount,maximunBattery) ;
    }

}
