using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    protected NPCController npc;
    // Start is called before the first frame update
    void Start()
    {
        npc = GetComponent<NPCController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("GDoor"))
        {
            Destroy(GameObject.FindGameObjectWithTag("GDoor"));
        }
        else
        {
            npc.wrongdoor = true;
        }
    }
}
