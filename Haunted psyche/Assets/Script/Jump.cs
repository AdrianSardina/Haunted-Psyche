using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    Rigidbody rb;
    float force;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        force = 10f;
    }

    // Update is called once per frame
    public void Jump()
    {                   
            rb.AddForce(Vector3.up *force,ForceMode.Impulse);           
    }
}
