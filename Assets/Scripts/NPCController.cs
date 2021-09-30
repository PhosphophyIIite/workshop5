using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : State
{
    protected NPCController npc;
    public bool wrongdoor;
    private GameObject NPC;
    private bool death;

    void Start()
    {
        NPC = GameObject.FindGameObjectWithTag("NPC");
        AddTransition<DEATH>(() => death == true);
    }

    public override void OnEnable()
    {
        death = false;

    }
    public override void OnDisable()
    {
        death = false;
    }
    // Update is called once per frame
    public override void Update()
    {
        if (npc.wrongdoor == true) {
            NPC.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("death")) {
            death = true;
        }
    }
}
