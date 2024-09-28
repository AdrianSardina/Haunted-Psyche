using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Movement")]

    #region variables
    float baseSpeed;
    float runningSpeed;
    float maxStamina;
    float currentStamina;
    bool canRun;
    Rigidbody rb;
    Vector3 direction;
    #endregion


    void Start()
    {
        canRun = true;
        currentStamina = 100f;
        maxStamina = 100f;
        baseSpeed = 6f;
        runningSpeed = 15f;
        rb = GetComponent<Rigidbody>(); 
    }

    public void Mover(float horizontal,float vertical,bool isRunning) 
    {
       
        //Running
        if (isRunning && canRun) 
        {
            direction = new Vector3(transform.forward.x * vertical * runningSpeed + transform.right.x * horizontal * runningSpeed, 
                                    rb.velocity.y,                                                                  
                                    transform.forward.z * vertical * runningSpeed + transform.right.z * horizontal * runningSpeed);
            rb.velocity = direction;

            DepleteStamina();
        }
        //Walking or Standing still
        else
        {        
            direction = new Vector3(transform.forward.x * vertical * baseSpeed + transform.right.x * horizontal * baseSpeed,
                                    rb.velocity.y,
                                    transform.forward.z * vertical * baseSpeed + transform.right.z * horizontal * baseSpeed);
            rb.velocity = direction;
            RechargeStamina();
        }    
    }
    private void DepleteStamina()
    {
            currentStamina -= Time.deltaTime *15f;
        if (currentStamina <= 0) 
        {
            
            canRun = false;
        }
    }
    private void RechargeStamina() 
    {

        if (currentStamina < maxStamina)
        {
            currentStamina += Time.deltaTime * 25f;


        }
        else 
        {
            currentStamina = Mathf.Min(maxStamina, currentStamina);
            canRun = true;
        }
    }
}
