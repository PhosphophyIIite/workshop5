using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWCHASING : State {
    public Transform player;
    protected NPCController npc;
    public float curRotSpeed;
    public float curSpeed;

    public void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        npc = GetComponent<NPCController>();

        curRotSpeed = 1.0f;
        curSpeed = 3.0f;
    }

    public override void Update()
    {
        base.Update();

        //Rotate to the target point
       ;

        Quaternion targetRotation = Quaternion.LookRotation(player.position - gameObject.transform.position);
        gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, targetRotation, Time.deltaTime * curRotSpeed);

        //Go Forward
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * curSpeed);
    }

}
   

