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

public abstract class BaseManager
{
    protected string _state;
    public abstract string state
    {
        get;
        set;
    }
    public abstract void Initialize();
}

public class CombatManager: BaseManager
{
    public override string state
    {
        get 
        {
            return _state;
        }
        set
        {
            _state = value;
        }

    }
    public override void Initialize()
    {
        _state = "Manager Initialized...";
        Debug.Log(_state);
    }
}


