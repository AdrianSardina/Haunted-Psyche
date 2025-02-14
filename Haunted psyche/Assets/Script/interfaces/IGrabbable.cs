using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGrabbable
{
    string Name { get; }
    int Weight  { get; } 
    float MaxDistance { get; }
     void AttachObject(Transform pos);
     void DettachObject();

}
