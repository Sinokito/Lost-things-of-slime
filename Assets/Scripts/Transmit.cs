using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmit : MonoBehaviour
{
    public Animator anim;
    private GameObject Slem;
    private GameObject Wind;
    public GameObject TransGoal;
    private void Start()
    {
        Slem = GameObject.Find("Slem");
        Wind = GameObject.Find("Wind");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player"&&anim.GetBool("BDoor"))
        {
            Slem.transform.position = TransGoal.transform.position;
            Wind.transform.position = TransGoal.transform.position + Vector3.left;
        }
    }
}
