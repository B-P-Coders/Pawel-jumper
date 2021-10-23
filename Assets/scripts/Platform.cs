using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private bool isActive = true;
    public void disactivated()
    {
        isActive = false;
    }
    public bool getActive()
    {
        return isActive;
    }
    
        
   
}
