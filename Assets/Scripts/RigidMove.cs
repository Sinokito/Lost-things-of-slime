using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidMove : MonoBehaviour
{
    //速度
    public float Speed;
    private Rigidbody2D Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        //移动
        float vmove = Input.GetAxis("Vertical");
        float hmove = Input.GetAxis("Horizontal");
        Player.velocity = new Vector2(hmove * Speed * Time.fixedDeltaTime, vmove * Speed * Time.fixedDeltaTime);
    }
}
