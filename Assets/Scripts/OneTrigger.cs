using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OneTrigger : MonoBehaviour
{
    public Animator anim;
    private int time = 0;


    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.up, float.MaxValue);
        if (time < 1 && hit.collider.tag == "Player")
        {
            anim.SetBool("B1", true);
            EventCenter.GetInstance().EventTrigger("OppenDoor1", this);
            time++;
        }
        if (hit.collider.tag != "Player")
        {
            anim.SetBool("B1", false);
            time = 0;
        }
    }

}
