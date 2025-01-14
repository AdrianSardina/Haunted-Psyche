using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickable
{
    string Name { get; }
   

    public void PickUp();
}
