
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class StateHighLevel : State
{

    public List<State> states;
    public State stateInitial;
    public State stateCurrent;



    public override void OnEnable()
    {
        base.OnEnable();
        if (stateCurrent == null)
            stateCurrent = stateInitial;
        stateCurrent.enabled = true;
    }

    public override void OnDisable()
    {
        base.OnDisable();
        stateCurrent.enabled = false;
        foreach (State t in states)
        {
            t.enabled = false;
        }
    }

}