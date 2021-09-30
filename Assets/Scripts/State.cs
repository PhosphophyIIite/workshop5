using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewTransition
{
    public Func<bool> condition;
    public State targetState;

}




public class State : MonoBehaviour
{
    public List<NewTransition> Transitions = new List<NewTransition>();
    public TextMesh StateText;
    


    //private void Start()
    //{
    //    Transitions 
    //}
    public virtual void OnEnable()
    {
        // TO-DO
        // develop state's initialization here

    }

    public virtual void OnDisable()
    {

    }

    public virtual void Update()
    {
        // TO-DO
        // develop behaviour here
    }

    
    protected void LateUpdate()
    {
        foreach (NewTransition t in Transitions)
        {
            if (t.condition())
            {
                t.targetState.enabled = true;
                enabled = false;
                return;
            }
        }
    }


    public void AddTransition<StateType>(Func<bool> condition) where StateType : State
    {
        NewTransition newTrans = new NewTransition
        {
            condition = condition,
            targetState = GetComponent<StateType>()
        };
        Transitions.Add(newTrans);
        
    }



}