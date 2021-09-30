using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathtransition : MonoBehaviour
{
    Animator m_Animator;
    bool death;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        death = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(death == true) { 
        m_Animator.Play("Scream");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("death"))
        {
            death = true; 
        }
    }
}
