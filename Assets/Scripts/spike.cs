using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spike : MonoBehaviour
{
    private GameObject Player;
    public Animator anim;
    public float DownLimit;
    void Start()
    {
        Player = GameObject.Find("Slem");
    }


    void Update()
    {
        if (Player.transform.position.y < DownLimit) reset();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            anim.SetBool("isDeath", true);
            Player.GetComponent<PlayerMove>().Speed = 0;
            Player.GetComponent<PlayerMove>().JumpHigh = 0;

            Invoke("reset", 1);
        }
    }
    private void reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

