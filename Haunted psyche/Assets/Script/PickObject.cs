using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObject : MonoBehaviour
{
    [SerializeField] Transform cameraPos;
    [SerializeField] LayerMask layerMask;
    [SerializeField] Transform attachPos;

   
    public void Grab()
    {
        if (Physics.Raycast(cameraPos.position, cameraPos.forward, out RaycastHit hit, 4f, layerMask))
        {
               
            IPickable item =hit.transform.GetComponent<IPickable>();
            item?.PickUp();
            
            ISwitchable s = hit.transform.GetComponent<ISwitchable>();
            s?.Toggle();


            IGrabbable grabing= hit.transform.GetComponent<IGrabbable>();
            
                grabing?.AttachObject(attachPos);
            
        }
    }
        
}


