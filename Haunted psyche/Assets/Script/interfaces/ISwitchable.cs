using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISwitchable {

    public bool IsActive { get; }
    public void Toggle();
}
