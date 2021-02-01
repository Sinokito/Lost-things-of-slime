﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeTrigger : MonoBehaviour
{
    public Animator anim;
    private int time = 0;


    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.up, float.MaxValue);
        if (time < 1 && hit.collider.tag == "Player")
        {
            anim.SetBool("B3", true);
            EventCenter.GetInstance().EventTrigger("OppenDoor3", this);
            time++;
        }
        if (hit.collider.tag != "Player")
        {
            anim.SetBool("B3", false);
            time = 0;
        }
    }
}
