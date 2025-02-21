using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IManager//declare a public interface
{    
   string state
    {
        get;
        set;
    }
    void Initialize();
}



