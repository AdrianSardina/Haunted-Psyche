using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float currentSanity;
    float maxSanity;
    float drainRate;
    public enum State 
    {
        Idle,
        Walking,
        Running,
        Jumping,
        Grabbing
    }
    public State currentState; 
    void Start()
    {
        currentState = State.Idle;
        maxSanity = 100f;
        currentSanity = maxSanity;
        drainRate = 0.25f;
        StartCoroutine(DrainSanity());
    }

    // Update is called once per frame
    IEnumerator DrainSanity() 
    {
        while (currentSanity >0) 
        {
            Debug.Log(currentSanity);
            LowerSanity(drainRate);
            yield return new WaitForSeconds(0.5f);
        }
        yield return null;
    }
    
    public void RaiseSanity(float amount) 
    {
        currentSanity = Mathf.Min(currentSanity+amount, maxSanity);
    }
    void LowerSanity(float amount)
    {
        currentSanity -= amount; 
    }
    public float GetCurrentSanity() 
    {
        return this.currentSanity;
    } 
}
