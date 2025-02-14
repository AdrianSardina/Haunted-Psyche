using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallObject : MonoBehaviour, IGrabbable
{
    Rigidbody body;
    bool grabbed;
    [SerializeField] Transform anchorPoint;

    private void Start()
    {
        grabbed = false;
        body = GetComponent<Rigidbody>();
        body.mass = (float)(Weight * 0.1);
    }
    public string Name => "small";
    public int Weight => 1;
    public float MaxDistance => 10;
    public void AttachObject(Transform pos)
    {
        if (grabbed)
        {
            DettachObject();
        }
        else 
        {
            transform.position = pos.position;
            body.useGravity = false;
            body.velocity = Vector3.zero;
            grabbed = true;
        }
       
        
    }
    public void DettachObject()
    {
        body.useGravity= true;
        grabbed=false;
    }
    private void Update()
    {
        if (grabbed) 
        {
         transform.position = anchorPoint.position; 
        }
    }

}
