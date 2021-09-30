using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEATH : State
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("death");
    }

    public override void OnEnable()
    {
        base.OnEnable();
        Explode();
    }
    protected void Explode()
    {

        Destroy(gameObject, 1.5f);
    }
}
